using System;
using rlbot.flat;


namespace RLBotCSharpExample
{
    public static class RLMath
    {
        public static readonly double deg2rad = 0.017453292;
        public static readonly double rad2deg = 57.29578049;
        
        public static Float2 Abs(Float2 f)
        {
            return new Float2(Math.Abs(f.x), Math.Abs(f.y));
        }
        public static Float3 Abs(Float3 f)
        {
            return new Float3(Math.Abs(f.x), Math.Abs(f.y), Math.Abs(f.z));
        }

        public static Float2 Normalize(Float2 f)
        {
            float distance = f.Length;
            return new Float2(f.x / distance, f.y / distance);
        }

        public static Float3 Normalize(Float3 f)
        {
            float distance = f.Length;
            return new Float3(f.x / distance, f.y / distance, f.z / distance);
        }

        public static float Distance(Float2 f1, Float2 f2)
        {
            return (float)Math.Sqrt((f2.x - f1.x) * (f2.x - f1.x) + (f2.y - f1.y)* (f2.y - f1.y));
        }

        public static float Distance(Float3 f1, Float3 f2)
        {
            return (float)Math.Sqrt((f2.x - f1.x) * (f2.x - f1.x) + (f2.y - f1.y) * (f2.y - f1.y) + (f2.z - f1.z) * (f2.z - f1.z));
        }
    }

    public struct Float2
    {
        public static readonly Float2 zero = new Float2(0, 0);
        public static readonly Float2 one = new Float2(1, 1);

        public float x;
        public float y;
        public Float2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public Float2(double x, double y)
        {
            this.x = (float)x;
            this.y = (float)y;
        }
        public Float2(Float2 other)
        {
            this.x = other.x;
            this.y = other.y;
        }
        public Float2(Vector3 other)
        {
            this.x = other.X;
            this.y = other.Y;
        }
        

        public Float2 Abs
        {
            get
            {
                return new Float2(Math.Abs(x), Math.Abs(y));
            }
        }

        public float Length
        {
            get
            {
                return (float)Math.Sqrt(x*x + y+y);
            }
        }

        public float SqrdLength
        {
            get
            {
                return x*x + y*y;
            }
        }

        public static Float2 operator *(Float2 f1, Float2 f2) { return new Float2(f1.x * f2.x, f1.y * f2.y); }
        public static Float2 operator /(Float2 f1, Float2 f2) { return new Float2(f1.x / f2.x, f1.y / f2.y); }
        public static Float2 operator -(Float2 f1, Float2 f2) { return new Float2(f1.x - f2.x, f1.y - f2.y); }
        public static Float2 operator +(Float2 f1, Float2 f2) { return new Float2(f1.x + f2.x, f1.y + f2.y); }
        public static Float2 operator %(Float2 f1, Float2 f2) { return new Float2(f1.x % f2.x, f1.y % f2.y); }
        public static Float2 operator ++(Float2 val) { return new Float2(++val.x, ++val.y); }
        public static Float2 operator --(Float2 val) { return new Float2(--val.x, --val.y); }

        public static bool operator >(Float2 f1, Float2 f2) { return f1.Length > f2.Length; }
        public static bool operator >=(Float2 f1, Float2 f2) { return f1.Length >= f2.Length; }
        public static bool operator <(Float2 f1, Float2 f2) { return f1.Length < f2.Length; }
        public static bool operator <=(Float2 f1, Float2 f2) { return f1.Length <= f2.Length; }

        public static Float2 operator -(Float2 val) { return new Float2(-val.x, -val.y); }
        public static Float2 operator +(Float2 val) { return new Float2(+val.x, +val.y); }

        public static bool operator ==(Float2 f1, Float2 f2) { return (f1.x == f2.x && f1.y == f2.y); }
        public static bool operator !=(Float2 f1, Float2 f2) { return (f1.x != f2.x && f1.y != f2.y); }

        public override string ToString()
        {
            return string.Format("X:{0} Y:{1}", x, y);
        }
    }

    public struct Float3
    {
        public static readonly Float3 zero = new Float3(0f, 0, 0);
        public static readonly Float3 one = new Float3(1f, 1f, 1f);

        public float x;
        public float y;
        public float z;
        public Float3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Float3(Float3 other)
        {
            this.x = other.x;
            this.y = other.y;
            this.z = other.z;
        }
        public Float3(Vector3 other)
        {
            this.x = other.X;
            this.y = other.Y;
            this.z = other.Z;
        }
        public Float3(Float2 other, float z)
        {
            this.x = other.x;
            this.y = other.y;
            this.z = z;
        }

        public Float3 Abs
        {
            get
            {
                return new Float3(Math.Abs(x), Math.Abs(y), Math.Abs(z));
            }
        }

        public float Length
        {
            get
            {
                return (float)Math.Sqrt(x*x + y+y + z*z);
            }
        }

        public float SqrdLength
        {
            get
            {
                return x*x + y*y + z*z;
            }
        }

        public static Float3 operator *(Float3 f1, Float3 f2) { return new Float3(f1.x * f2.x, f1.y * f2.y, f1.z * f2.z); }
        public static Float3 operator /(Float3 f1, Float3 f2) { return new Float3(f1.x / f2.x, f1.y / f2.y, f1.z / f2.z); }
        public static Float3 operator -(Float3 f1, Float3 f2) { return new Float3(f1.x - f2.x, f1.y - f2.y, f1.z - f2.z); }
        public static Float3 operator +(Float3 f1, Float3 f2) { return new Float3(f1.x + f2.x, f1.y + f2.y, f1.z + f2.z); }
        public static Float3 operator %(Float3 f1, Float3 f2) { return new Float3(f1.x % f2.x, f1.y % f2.y, f1.z % f2.z); }
        public static Float3 operator ++(Float3 val) { return new Float3(++val.x, ++val.y, ++val.z); }
        public static Float3 operator --(Float3 val) { return new Float3(--val.x, --val.y, --val.z); }

        public static bool operator >(Float3 f1, Float3 f2) { return f1.Length > f2.Length; }
        public static bool operator >=(Float3 f1, Float3 f2) { return f1.Length >= f2.Length; }
        public static bool operator <(Float3 f1, Float3 f2) { return f1.Length < f2.Length; }
        public static bool operator <=(Float3 f1, Float3 f2) { return f1.Length <= f2.Length; }

        public static Float3 operator -(Float3 val) { return new Float3(-val.x, -val.y, val.z); }
        public static Float3 operator +(Float3 val) { return new Float3(+val.x, +val.y, +val.z); }

        public static bool operator ==(Float3 f1, Float3 f2) { return (f1.x == f2.x && f1.y == f2.y && f1.z == f2.z); }
        public static bool operator !=(Float3 f1, Float3 f2) { return (f1.x != f2.x && f1.y != f2.y && f1.z != f2.z); }

        public override string ToString()
        {
            return string.Format("X:{0} Y:{1} Z:{2}", x, y, z);
        }
    }
}
