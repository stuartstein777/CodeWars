public class MathCheck {
    public static int AreaOrPerimeter(int l, int w)
      => (l == w)
          ? l * w
          : l + l + w + w;
}