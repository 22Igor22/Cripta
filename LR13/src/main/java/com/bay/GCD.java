package com.bay;

public class GCD {
    public static int mod(int x, int m) {
        return (x % m + m) % m;
    }

    public static int modInverse(int a, int m) {
        a = a % m;
        for (int x = 1; x < m; x++) {
            if ((a * x) % m == 1) {
                return x;
            }
        }
        return 1;
    }
}
