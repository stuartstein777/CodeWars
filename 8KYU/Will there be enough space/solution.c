int enough(int cap, int on, int wait)
{
    return on + wait <= cap
        ? 0
        : wait - (cap - on);
}