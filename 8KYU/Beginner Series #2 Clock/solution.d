module solution;

export uint past(uint h, uint m, uint s) 
{
    return s * 1000 + m * 60000 + h * 3600000;
}
