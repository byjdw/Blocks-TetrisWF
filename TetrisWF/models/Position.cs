using System;
using System.Drawing;

namespace AS_Coursework.models
{

    public sealed class Position : IEquatable<Position>
    {
        public static readonly Position ZERO = new(0.0f, 0.0f);

        public Position()
        {
            x = 0;
            y = 0;
        }

        public Position(float _x, float _y)
        {
            x = _x;
            y = _y;
        }

        public float x { get; set; }

        public float y { get; set; }

        public bool Equals(Position other)
        {
            return x == other.x &&
                   y == other.y;
        }

        public override string ToString()
        {
            return "Vector2 {\v" +
                   new string('\b', 5) + x + ",\v" +
                   new string('\b', x.ToString().Length + 1) + y + "\v" +
                   new string('\b', y.ToString().Length + 4) + // Go back to same column as the "V" of "Vector2"
                   "}";
        }

        public float dot(Position other)
        {
            var total = 0.0f;
            total += x * other.x;
            total += y * other.y;
            return total;
        }

        public float magnitude()
        {
            return (float)Math.Sqrt((float)Math.Pow(x, 2.0f) + (float)Math.Pow(y, 2.0f));
        }

        public Position interp(Position other, float interp_amt)
        {
            return this + (other - this) * interp_amt;
        }

        public Position midpoint(Position other)
        {
            return (this + other) / 2.0f;
        }

        public Position unit()
        {
            var mag = magnitude();
            return new Position(x / mag, y / mag);
        }

        public Position rotate(float theta)
        {
            theta *= 0.0174533f;
            return new Position(x * (float)Math.Cos(theta) - y * (float)Math.Sin(theta),
                x * (float)Math.Sin(theta) + y * (float)Math.Cos(theta));
        }

        public static bool operator ==(Position self, Position other)
        {
            return self.Equals(other);
        }

        public static bool operator !=(Position self, Position other)
        {
            return !self.Equals(other);
        }

        public static Position operator +(Position self, Position other)
        {
            return new Position(self.x + other.x, self.y + other.y);
        }

        public static Position operator -(Position self, Position other)
        {
            return new Position(self.x - other.x, self.y - other.y);
        }

        public static Position operator *(Position self, float other)
        {
            return new Position(self.x * other, self.y * other);
        }

        public static Position operator /(Position self, float other)
        {
            return new Position(self.x / other, self.y / other);
        }

        public static implicit operator PointF(Position self)
        {
            return new PointF(self.x, self.y);
        }
    }
}