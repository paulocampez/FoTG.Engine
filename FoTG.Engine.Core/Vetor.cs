using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoTG.Engine.Core
{
    using SFML.System;
    public struct Vetor : IEquatable<Vetor>
    {
        public float x;
        public float y;

        public static readonly Vetor Zero = new Vetor(0);
        public static readonly Vetor One = new Vetor(1f);


        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Vetor(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="value"></param>
        public Vetor(float value) : this(value, value)
        { }

        /// <summary>
        /// Verifica se o vetor é igual
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Vetor other)
            => other.x == x && other.y == y;

        /// <summary>
        /// Verifica se o vetor é igual
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Int2 other)
            => other.x == (int)x && other.y == (int)y;

        /// <summary>
        /// Distância entre 2 pontos
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public float Distance(Vetor other)
            => (float)Math.Sqrt(Math.Pow(x - other.x, 2) + Math.Pow(y - other.y, 2));

        public Int2 ToInt2()
            => new Int2((int)x, (int)y);

        public override int GetHashCode()
            => x.GetHashCode() + y.GetHashCode();

        public override bool Equals(object obj)
            => (obj is Vetor || obj is Int2) && Equals((Vetor)obj);

        public Vetor Floor()
            => new Vetor((float)Math.Floor(x), (float)Math.Floor(y));

        public Vetor Round()
            => new Vetor((float)Math.Round(x, 2), (float)Math.Round(y, 2));

        public Vetor Ceiling()
            => new Vetor(MathF.Ceiling(x), MathF.Ceiling(y));

        public Vetor ToInt()
            => new Vetor((int)x, (int)y);

        public static Vetor Max(Vetor v1, Vetor v2)
            => new Vetor(MathF.Max(v1.x, v2.x), MathF.Max(v1.y, v2.y));

        public static Vetor Min(Vetor v1, Vetor v2)
            => new Vetor(MathF.Min(v1.x, v2.x), MathF.Min(v1.y, v2.y));

        #region Operators
        public static Vetor operator -(Vetor value, Vetor other)
            => new Vetor(value.x - other.x, value.y - other.y);

        public static Vetor operator -(Vetor value, float other)
            => new Vetor(value.x - other, value.y - other);

        public static Vetor operator +(Vetor value, Vetor other)
            => new Vetor(value.x + other.x, value.y + other.y);

        public static Vetor operator +(Vetor value, float other)
            => new Vetor(value.x + other, value.y + other);

        public static Vetor operator *(Vetor value, Vetor other)
            => new Vetor(value.x * other.x, value.y * other.y);

        public static Vetor operator *(Vetor value, float other)
            => new Vetor(value.x * other, value.y * other);

        public static Vetor operator /(Vetor value, Vetor other)
            => new Vetor(value.x / other.x, value.y / other.y);

        public static Vetor operator /(Vetor value, float other)
            => new Vetor(value.x / other, value.y / other);

        public static bool operator ==(Vetor value, Vetor other)
            => value.x == other.x && value.y == other.y;

        public static bool operator !=(Vetor value, Vetor other)
            => value.x != other.x || value.y != other.y;

        public static implicit operator Int2(Vetor v)
           => new Int2((int)v.x, (int)v.y);

        public static explicit operator Vetor(Int2 v)
            => new Vetor(v.x, v.y);

        public static implicit operator Vector2f(Vetor v)
            => new Vector2f(v.x, v.y);

        public static explicit operator Vetor(Vector2f v)
            => new Vetor(v.X, v.Y);

        public static implicit operator Vector2i(Vetor v)
            => new Vector2i((int)v.x, (int)v.y);

        public static explicit operator Vetor(Vector2i v)
            => new Vetor(v.X, v.Y);

        public static implicit operator Vector2u(Vetor v)
            => new Vector2u((uint)v.x, (uint)v.y);

        public static explicit operator Vetor(Vector2u v)
            => new Vetor(v.X, v.Y);
        #endregion

    }

}
