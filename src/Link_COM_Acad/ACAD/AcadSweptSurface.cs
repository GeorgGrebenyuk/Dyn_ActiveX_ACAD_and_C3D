namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadSweptSurface 
	{
		public Autodesk.AutoCAD.Interop.Common.IAcadSweptSurface _i;
		internal AcadSweptSurface(object AcadSweptSurface_object) 
		{
			this._i = AcadSweptSurface_object as Autodesk.AutoCAD.Interop.Common.IAcadSweptSurface;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ProfileRotation => this._i.ProfileRotation;

		///<summary>
		///
		///</summary>
		public void Set_ProfileRotation(dynamic profileRotationAngle) 
		{
			this._i.ProfileRotation = profileRotationAngle;
		}

		///<summary>
		///
		///</summary>
		public bool Bank => this._i.Bank;

		///<summary>
		///
		///</summary>
		public void Set_Bank(bool bBank) 
		{
			this._i.Bank = bBank;
		}

		///<summary>
		///
		///</summary>
		public dynamic Twist => this._i.Twist;

		///<summary>
		///
		///</summary>
		public void Set_Twist(dynamic TwistAngle) 
		{
			this._i.Twist = TwistAngle;
		}

		///<summary>
		///
		///</summary>
		public double scale => this._i.scale;

		///<summary>
		///
		///</summary>
		public void Set_scale(double scale) 
		{
			this._i.scale = scale;
		}

		///<summary>
		///
		///</summary>
		public double Length => this._i.Length;
	}
}
