def dynamic_caller(obj, method)
    obj.public_send(method)
end