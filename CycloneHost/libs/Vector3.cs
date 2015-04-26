using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CycloneHost
{
	public struct Vector3
	{

		public double X, Y, Z;

		public Vector3(double x, double y, double z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		public static Vector3 operator +(Vector3 _1, Vector3 _2)
		{
			return new Vector3(_1.X + _2.X, _1.Y + _2.Y, _1.Z + _2.Z);
		}

		public static Vector3 operator -(Vector3 _1, Vector3 _2)
		{
			return new Vector3(_1.X - _2.X, _1.Y - _2.Y, _1.Z - _2.Z);
		}

		public static Vector3 operator *(Vector3 _1, double factor)
		{
			return new Vector3(_1.X * factor, _1.Y * factor, _1.Z * factor);
		}

		public static Vector3 operator /(Vector3 _1, double factor)
		{
			return new Vector3(_1.X / factor, _1.Y / factor, _1.Z / factor);
		}

		public static bool operator ==(Vector3 _1, Vector3 _2)
		{
			return _1.X == _2.X && _1.Y == _2.Y && _1.Z == _2.Z;
		}

		public static bool operator !=(Vector3 _1, Vector3 _2)
		{
			return _1.X != _2.X || _1.Y != _2.Y || _1.Z != _2.Z;
		}

		public double Length
		{
			get
			{
				return Math.Sqrt(X * X + Y * Y + Z * Z);
			}
		}
	}
}
