namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadHelix 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadHelix _i;
		internal AcadHelix(object AcadHelix_object) 
		{
			this._i = AcadHelix_object as Autodesk.AutoCAD.Interop.Common.AcadHelix;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public object Position => this._i.Position;

		///<summary>
		///
		///</summary>
		public void Set_Position(object StartPoint) 
		{
			this._i.Position = StartPoint;
		}

		///<summary>
		///
		///</summary>
		public dynamic Constrain => this._i.Constrain;

		///<summary>
		///
		///</summary>
		public void Set_Constrain(Autodesk.AutoCAD.Interop.Common.AcHelixConstrainType constrainType) 
		{
			this._i.Constrain = constrainType;
		}

		///<summary>
		///
		///</summary>
		public double Height => this._i.Height;

		///<summary>
		///
		///</summary>
		public void Set_Height(double Length) 
		{
			this._i.Height = Length;
		}

		///<summary>
		///
		///</summary>
		public dynamic Turns => this._i.Turns;

		///<summary>
		///
		///</summary>
		public void Set_Turns(dynamic Turns) 
		{
			this._i.Turns = Turns;
		}

		///<summary>
		///
		///</summary>
		public double TurnHeight => this._i.TurnHeight;

		///<summary>
		///
		///</summary>
		public void Set_TurnHeight(double Distance) 
		{
			this._i.TurnHeight = Distance;
		}

		///<summary>
		///
		///</summary>
		public double BaseRadius => this._i.BaseRadius;

		///<summary>
		///
		///</summary>
		public void Set_BaseRadius(double Radius) 
		{
			this._i.BaseRadius = Radius;
		}

		///<summary>
		///
		///</summary>
		public double TopRadius => this._i.TopRadius;

		///<summary>
		///
		///</summary>
		public void Set_TopRadius(double Radius) 
		{
			this._i.TopRadius = Radius;
		}

		///<summary>
		///
		///</summary>
		public dynamic Twist => this._i.Twist;

		///<summary>
		///
		///</summary>
		public void Set_Twist(Autodesk.AutoCAD.Interop.Common.AcHelixTwistType twistType) 
		{
			this._i.Twist = twistType;
		}

		///<summary>
		///
		///</summary>
		public dynamic TurnSlope => this._i.TurnSlope;

		///<summary>
		///
		///</summary>
		public double TotalLength => this._i.TotalLength;
	}
}
