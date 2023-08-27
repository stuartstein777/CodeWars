const zero = (op) => op === undefined ? 0 : op(0);
const one = (op) => op === undefined ? 1 : op(1);
const two = (op) => op === undefined ? 2 : op(2);
const three = (op) => op === undefined ? 3 : op(3);
const four = (op) => op === undefined ? 4 : op(4);
const five = (op) => op === undefined ? 5 : op(5);
const six = (op) => op === undefined ? 6 : op(6);
const seven = (op) => op === undefined ? 7 : op(7);
const eight = (op) => op === undefined ? 8 : op(8);
const nine = (op) => op === undefined ? 9 : op(9);

const plus = (b) => (a) => a + b;
const minus = (b) => (a) => a - b;
const times = (b) => (a) => a * b;
const dividedBy = (b) => (a) => Math.floor(a / b);