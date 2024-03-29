## 0. BootCamp

The Euclidean algorithm for calculating the greatest common divisor (GCD) of two numbers is a classic example of recursion. The central idea is that if y > x, the GCD of x and y is the GCD of x and y-x. For example, GCD(156,36) = GCD((156-36) = 120,36).

By extension, this implies that the GCD of x and y is the GCD of x and y mod x, i.e., GCD(156,36) = GCD((156 mod 36) = 12,36) = GCD(12,36 mod 12 = 0) = 12.