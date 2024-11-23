
public class Complex {
    public dynamic Real { get; set; }
    public dynamic Imaginary { get; set; }

    public Complex(dynamic real, dynamic imaginary) {
        Real = real;
        Imaginary = imaginary;
    }

    public static Complex operator +(Complex a, Complex b) {
        return new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
    }

    public static Complex operator -(Complex a, Complex b) {
        return new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);
    }

    public static Complex operator *(Complex a, Complex b) {
        double real = a.Real * b.Real - a.Imaginary * b.Imaginary;
        double imaginary = a.Real * b.Imaginary + a.Imaginary * b.Real;
        return new Complex(real, imaginary);
    }

    public static Complex operator /(Complex a, Complex b) {
        double denominator = b.Real * b.Real + b.Imaginary * b.Imaginary;
        double real = (a.Real * b.Real + a.Imaginary * b.Imaginary) / denominator;
        double imaginary = (a.Imaginary * b.Real - a.Real * b.Imaginary) / denominator;
        return new Complex(real, imaginary);
    }

    public override string ToString() {
        return $"{Real} + {Imaginary}i";
    }
}