def get_status(is_busy):
    if is_busy:
        return {"status": "busy"}
    else:
        return {"status": "available"}
    