using System;
using System.Security;
using System.Runtime.InteropServices;

namespace Question1
{
	public class Rectangle
	{
		public float height = 1.0f;

		public float width = 1.0f;



		public Rectangle (float height, float width)
		{

			this.height = height;

			this.width = width;

		}


		public float Height {

			get{ return this.height; }

			set { 
				if ((value > 0.0) && (value < 20.0)) {

					this.height = value;
				} 
			}
		}

		public float Width {

			get{ return this.width; }

			set { 
				if ((value > 0.0) && (value < 20.0)) {

					this.width = value;
				} 
			}
		}

		public float Area ()
		{

			return  Width * Height; 

		}
	}
}

