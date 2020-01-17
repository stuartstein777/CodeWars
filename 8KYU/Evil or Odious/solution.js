function evil(n) {
    return (n.toString(2).replace(/0/g, '').length % 2 == 0)
              ? "It's Evil!"
              : "It's Odious!";
}