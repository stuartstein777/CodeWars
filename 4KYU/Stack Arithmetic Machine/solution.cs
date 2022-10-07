using System;
public class Machine
{
    private Cpu cpu;
  
    public Machine(Cpu cpu = null) => this.cpu = cpu;

    private int GetValueOrValueInRegister(Operand operand) =>
        operand.OperandType == OperandType.Register
            ? cpu.ReadReg(operand.Register)
            : operand.Val.Value;

    /// <summary>
    /// Mov:
    ///
    /// mov 4, b    : moves 4 to "b"
    /// mov a, b    : moves the value in register "a" to the regsiter "b"
    /// </summary>
    private void Mov(Instruction instruction)
    {
        // IF its a register, get the value in that register and put it dest-reg
        var r = GetValueOrValueInRegister(instruction.Operand);
        cpu.WriteReg(instruction.DestReg, r);
    }

    /// <summary>
    /// Push [reg|int]
    ///
    /// Pushes either int or the the value at reg onto the stack.
    ///
    /// push a      : pushes the value in register "a" onto the stack.
    /// push 5      : pushes the value 5 onto the stack.
    /// </summary>
    private void Push(Instruction instruction)
    {
        var r = GetValueOrValueInRegister(instruction.Operand);
        cpu.WriteStack(r);
    }

    /// <summary>
    /// Pop [reg]
    ///
    /// Pops the value of the top of the stack, if no operand provided this value is discarded.
    /// Otherwise the value is stored in the operand [reg]
    ///
    /// pop         : Pops the value off the stack, value is discarded.
    /// pop a       : Pops the value off the stack, stores it in register "a"
    /// </summary>
    private void Pop(Instruction instruction)
    {
        if (instruction.Operand is { OperandType: OperandType.Register })
            cpu.WriteReg(instruction.Operand.Register, cpu.PopStack());
        else
            cpu.PopStack();
    }

    /// <summary>
    /// pushr
    ///
    /// Pushes the general registers (a, b, c, d) onto the stack, in order.
    ///
    /// mov a 1
    /// mov b 2
    /// mov c 3
    /// mov d 4
    /// pushr
    ///
    /// Stack now contains 1 2 3 4
    /// </summary>
    private void Pushr()
    {
        cpu.WriteStack(cpu.ReadReg("a"));
        cpu.WriteStack(cpu.ReadReg("b"));
        cpu.WriteStack(cpu.ReadReg("c"));
        cpu.WriteStack(cpu.ReadReg("d"));
    }

    /// <summary>
    /// pushrr
    ///
    /// Pushes the general registers (a, b, c, d) onto the stack, in reverse order.
    ///
    /// mov a 1
    /// mov b 2
    /// mov c 3
    /// mov d 4
    /// pushrr
    ///
    /// Stack now contains 4 3 2 1
    /// </summary>
    private void Pushrr()
    {
        cpu.WriteStack(cpu.ReadReg("d"));
        cpu.WriteStack(cpu.ReadReg("c"));
        cpu.WriteStack(cpu.ReadReg("b"));
        cpu.WriteStack(cpu.ReadReg("a"));
    }

    /// <summary>
    /// Pops the values off the stack and puts them in the registers a, b, c, d
    /// </summary>
    private void Popr()
    {
        cpu.WriteReg("d", cpu.PopStack());
        cpu.WriteReg("c", cpu.PopStack());
        cpu.WriteReg("b", cpu.PopStack());
        cpu.WriteReg("a", cpu.PopStack());
    }
    
    /// <summary>
    /// Pops the values off the stack and puts them in the registers a, b, c, d
    /// </summary>
    private void Poprr()
    {
        cpu.WriteReg("a", cpu.PopStack());
        cpu.WriteReg("b", cpu.PopStack());
        cpu.WriteReg("c", cpu.PopStack());
        cpu.WriteReg("d", cpu.PopStack());
    }

    /// <summary>
    /// Add [reg|int]
    ///
    /// add [reg|int]       : Pops [reg|int] args off the stack, stores the sum in register a.
    /// add [reg|int] [reg] : Pops [reg|int] args off the stack, stores the sum in register [reg]
    /// </summary>
    /// <param name="instruction"></param>
    private void Arith(Instruction instruction, Func<int, int, int> arithOperation)
    {
        var toPop = GetValueOrValueInRegister(instruction.Operand);
        var total = cpu.PopStack();
        for (var i = 1; i < toPop; i++)
            total = arithOperation(total, cpu.PopStack());

        cpu.WriteReg(string.IsNullOrEmpty(instruction.DestReg)
                        ? "a"
                        : instruction.DestReg, total);
    }

    private void Process(Instruction instruction)
    {
        if (instruction.Op == "mov")
        {
            Mov(instruction);
        }
        else if (instruction.Op == "push")
        {
            Push(instruction);
        }
        else if (instruction.Op == "pop")
        {
            Pop(instruction);
        }
        else if (instruction.Op == "pushr")
        {
            Pushr();
        }
        else if (instruction.Op == "pushrr")
        {
            Pushrr();
        }
        else if (instruction.Op == "popr")
        {
            Popr();
        }
        else if (instruction.Op == "poprr")
        {
            Poprr();
        }
        else if (instruction.Op.StartsWith("add"))
        {
            if (instruction.Op.Length > 3)
            {
                var reg = instruction.Op[3].ToString();
                var toPush = cpu.ReadReg(reg);
                cpu.WriteStack(toPush);
            }
            Arith(instruction, (x, y) => x + y);
        }
        else if (instruction.Op.StartsWith("mul"))
        {
            if (instruction.Op.Length > 3)
            {
                var reg = instruction.Op[3].ToString();
                var toPush = cpu.ReadReg(reg);
                cpu.WriteStack(toPush);
            }
            Arith(instruction, (x, y) => x * y);
        }
        else if (instruction.Op.StartsWith("sub"))
        {
            if (instruction.Op.Length > 3)
            {
                var reg = instruction.Op[3].ToString();
                var toPush = cpu.ReadReg(reg);
                cpu.WriteStack(toPush);
            }
            Arith(instruction, (x, y) => x - y);
        }
        else if (instruction.Op.StartsWith("div"))
        {
            if (instruction.Op.Length > 3)
            {
                var reg = instruction.Op[3].ToString();
                var toPush = cpu.ReadReg(reg);
                cpu.WriteStack(toPush);
            }
            Arith(instruction, (x, y) => x / y);
        }
        else if (instruction.Op.StartsWith("and"))
        {
            if (instruction.Op.Length > 3)
            {
                var reg = instruction.Op[3].ToString();
                var toPush = cpu.ReadReg(reg);
                cpu.WriteStack(toPush);
            }
            Arith(instruction, (x, y) => x & y);
        }
        else if (instruction.Op.StartsWith("or"))
        {
            if (instruction.Op.Length > 2)
            {
                var reg = instruction.Op[2].ToString();
                var toPush = cpu.ReadReg(reg);
                cpu.WriteStack(toPush);
            }
            Arith(instruction, (x, y) => x | y);
        }
        else if (instruction.Op.StartsWith("xor"))
        {
            if (instruction.Op.Length > 3)
            {
                var reg = instruction.Op[3].ToString();
                var toPush = cpu.ReadReg(reg);
                cpu.WriteStack(toPush);
            }
            Arith(instruction, (x, y) => x ^ y);
        }
    }
    
    private Instruction ParseInstruction(string op)
    {
        var opAndReg = op.Replace(",", "").Split(" ");
        // can have 1. e.g.    pop
        // can have 2. e.g.    pop [reg|int],
        // can have 3. e.g.    mov [reg|int] [reg2]
        if (opAndReg.Length == 3)
        {
            var @operator = opAndReg[0];
            var destReg = opAndReg[2];
            return int.TryParse(opAndReg[1], out var v)
                ? new Instruction(@operator, new Operand(v), destReg)
                : new Instruction(@operator, new Operand(opAndReg[1]), destReg);
        }

        if (opAndReg.Length == 2)
        {
            var @operator = opAndReg[0];
            return int.TryParse(opAndReg[1], out var v)
                ? new Instruction(@operator, new Operand(v))
                : new Instruction(@operator, new Operand(opAndReg[1]));
        }

        return new Instruction(op);
    }
    
    public void Exec(string op)
    {
        Console.WriteLine(op);
        var instruction = ParseInstruction(op);
        Process(instruction);
    }
}

public class Instruction
{
    public string Op { get; }
    public Operand Operand { get; }
    public string DestReg { get; }

    public Instruction(string op, Operand operand, string destReg)
    {
        Op = op;
        Operand = operand;
        DestReg = destReg;
    }

    public Instruction(string op, Operand operand) : this(op, operand, null) {}
    
    public Instruction(string op) : this(op, null, null) {}
}

public enum OperandType
{
    Register,
    Value
}

public class Operand
{
    public string Register { get; }
    public int? Val { get; }

    public OperandType OperandType { get; }

    public Operand(string register)
    {
        Register = register;
        Val = null;
        OperandType = OperandType.Register;
    }
    public Operand(int val)
    {
        Register = null;
        Val = val;
        OperandType = OperandType.Value;
    }
}