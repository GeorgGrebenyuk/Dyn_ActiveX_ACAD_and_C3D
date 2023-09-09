namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileEntities 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfileEntities _i;
		internal AeccProfileEntities(object AeccProfileEntities_object) 
		{
			this._i = AeccProfileEntities_object as Autodesk.AECC.Interop.Land.IAeccProfileEntities;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic FirstEntity => this._i.FirstEntity;

		///<summary>
		///
		///</summary>
		public dynamic LastEntity => this._i.LastEntity;

		///<summary>
		///
		///</summary>
		public dynamic Item(dynamic nIndex) 
		{
			return this._i.Item(nIndex);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object varId) 
		{
			this._i.Remove(varId);
		}

		///<summary>
		///
		///</summary>
		public void RemoveAll() 
		{
			this._i.RemoveAll();
		}

		///<summary>
		///
		///</summary>
		public dynamic EntityAtId(dynamic nId) 
		{
			return this._i.EntityAtId(nId);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFixedTangent(object varPoint1,object varPoint2) 
		{
			return this._i.AddFixedTangent(varPoint1,varPoint2);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFixedTangentWithPreviousEntity(dynamic nPrevEntityId,object varPoint1,object varPoint2) 
		{
			return this._i.AddFixedTangentWithPreviousEntity(nPrevEntityId,varPoint1,varPoint2);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFloatingTangent(dynamic nAttachId,object varPassPoint) 
		{
			return this._i.AddFloatingTangent(nAttachId,varPassPoint);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFreeTangent(dynamic nBeforeId,dynamic nAfterId) 
		{
			return this._i.AddFreeTangent(nBeforeId,nAfterId);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFixedSymmetricParabolaByThreePoints(object varPoint1,object varPoint2,object varPoint3) 
		{
			return this._i.AddFixedSymmetricParabolaByThreePoints(varPoint1,varPoint2,varPoint3);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFixedSymmetricParabolaByTwoPointsAndK(object varPoint1,object varPoint2,Autodesk.AECC.Interop.Land.AeccProfileVerticalCurveType eVerticalCurveType,double dK) 
		{
			return this._i.AddFixedSymmetricParabolaByTwoPointsAndK(varPoint1,varPoint2,eVerticalCurveType,dK);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFixedSymmetricParabolaByTwoPointsAndRadius(object varPoint1,object varPoint2,Autodesk.AECC.Interop.Land.AeccProfileVerticalCurveType eVerticalCurveType,double dRadius) 
		{
			return this._i.AddFixedSymmetricParabolaByTwoPointsAndRadius(varPoint1,varPoint2,eVerticalCurveType,dRadius);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFixedSymmetricParabolaByEntityEndAndThroughPoint(dynamic nAttachId,object varPassPoint) 
		{
			return this._i.AddFixedSymmetricParabolaByEntityEndAndThroughPoint(nAttachId,varPassPoint);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFixedSymmetricParabolaByTwoPointsAndStartGrade(object varPoint1,object varPoint2,double dStartGrade) 
		{
			return this._i.AddFixedSymmetricParabolaByTwoPointsAndStartGrade(varPoint1,varPoint2,dStartGrade);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFixedSymmetricParabolaByTwoPointsAndEndGrade(object varPoint1,object varPoint2,double dEndGrade) 
		{
			return this._i.AddFixedSymmetricParabolaByTwoPointsAndEndGrade(varPoint1,varPoint2,dEndGrade);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFloatingSymmetricParabolaByThroughPointAndK(dynamic nAttachId,object varPassPoint,double dK) 
		{
			return this._i.AddFloatingSymmetricParabolaByThroughPointAndK(nAttachId,varPassPoint,dK);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFloatingSymmetricParabolaByThroughPointAndRadius(dynamic nAttachId,object varPassPoint,double dRadius) 
		{
			return this._i.AddFloatingSymmetricParabolaByThroughPointAndRadius(nAttachId,varPassPoint,dRadius);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFloatingSymmetricParabolaByThroughPointAndEndGrade(dynamic nAttachId,object varPassPoint,double dEndGrade) 
		{
			return this._i.AddFloatingSymmetricParabolaByThroughPointAndEndGrade(nAttachId,varPassPoint,dEndGrade);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFreeSymmetricParabolaByLength(dynamic nBeforeId,dynamic nAfterId,Autodesk.AECC.Interop.Land.AeccProfileVerticalCurveType eVerticalCurveType,double dLength,bool bPreferFlat) 
		{
			return this._i.AddFreeSymmetricParabolaByLength(nBeforeId,nAfterId,eVerticalCurveType,dLength,bPreferFlat);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFreeSymmetricParabolaByK(dynamic nBeforeId,dynamic nAfterId,Autodesk.AECC.Interop.Land.AeccProfileVerticalCurveType eVerticalCurveType,double dK) 
		{
			return this._i.AddFreeSymmetricParabolaByK(nBeforeId,nAfterId,eVerticalCurveType,dK);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFreeSymmetricParabolaByRadius(dynamic nBeforeId,dynamic nAfterId,Autodesk.AECC.Interop.Land.AeccProfileVerticalCurveType eVerticalCurveType,double dRadius) 
		{
			return this._i.AddFreeSymmetricParabolaByRadius(nBeforeId,nAfterId,eVerticalCurveType,dRadius);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFreeSymmetricParabolaByPVIAndCurveLength(dynamic pPVI,double dCurveLength) 
		{
			return this._i.AddFreeSymmetricParabolaByPVIAndCurveLength(pPVI,dCurveLength);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFreeSymmetricParabolaByPVIAndThroughPoint(dynamic pPVI,object varPassPoint) 
		{
			return this._i.AddFreeSymmetricParabolaByPVIAndThroughPoint(pPVI,varPassPoint);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFreeSymmetricParabolaByPVIAndK(dynamic pPVI,double dK) 
		{
			return this._i.AddFreeSymmetricParabolaByPVIAndK(pPVI,dK);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFreeAsymmetricParabolaByPVIAndLengths(dynamic pPVI,double dLength1,double dLength2) 
		{
			return this._i.AddFreeAsymmetricParabolaByPVIAndLengths(pPVI,dLength1,dLength2);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFreeCircularCurveByPVIAndThroughPoint(dynamic pPVI,object varPassPoint) 
		{
			return this._i.AddFreeCircularCurveByPVIAndThroughPoint(pPVI,varPassPoint);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFreeCircularCurveByPVIAndRadius(dynamic pPVI,double dRadius) 
		{
			return this._i.AddFreeCircularCurveByPVIAndRadius(pPVI,dRadius);
		}
	}
}
