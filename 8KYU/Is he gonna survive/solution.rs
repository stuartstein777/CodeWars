fn hero(bullets: u16, dragons: u16) -> bool {
    return bullets >= (dragons << 1)
}