package bay.cripta;

public class Functions {
    public static int NOD(int x, int y) {
        while (x != 0 && y != 0) {
            if (x > y) {
                x -= y;
            } else {
                y -= x;
            }
        }
        return Math.max(x, y);
    }

    public static boolean isSimple(int x) {
        for (int i = 2; Math.pow(i, 2) <= x; i++) {
            if (x % i == 0) {
                return false;
            }
        }
        return true;
    }

    public static void findSimple(int m, int n) {
        int counter = 0;
        if (n < m) {
            System.out.println("Wrong range!");
        }
        System.out.println("Simple numbers in range " + m + " to " + n);

        for (int i = m; i <= n; i++) {
            if (isSimple(i)) {
                System.out.print(" " + i);
                counter++;
            }
        }
        System.out.println();
        System.out.println("Simple numbers count " + counter);
    }

    public static void canonicalNotation(int x) {
        String str = "1";
        int power = 1;
        Boolean isEven = false;
        for (int i = 0; x % 2 == 0; x /= 2, i++) {
            isEven = true;
            if (i != 0) {
                power++;
            }
        }
        if (isEven)
            str += " * 2";
        if (power != 1)
            str += "^" + power;
        power = 0;
        for (int i = 3; i <= x; ) {
            if (x % i == 0) {
                power++;
                x /= i;
                if (i == x) {
                    power++;
                    str += " * " + i;
                    if (power != 1)
                        str += "^" + power;
                    break;
                }
            } else {
                str += " * " + i;
                if (power != 1)
                    str += "^" + power;
                power = 0;
                i += 2;
                if (i == x) {
                    power++;
                    str += " * " + i;
                    if (power != 1)
                        str += "^" + power;
                    break;
                }
            }
        }
        System.out.println(str);
    }
}
