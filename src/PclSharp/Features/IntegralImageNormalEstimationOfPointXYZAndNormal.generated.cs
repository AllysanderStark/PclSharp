
// Code generated by a template
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using PclSharp.Struct;
using PclSharp.Std;
using PclSharp.Search;	
using static PclSharp.Features.IntegralImageNormalEstimation;

namespace PclSharp.Features
{
	public static partial class Invoke
	{
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern IntPtr features_integralImageNormalEstimation_pointxyzandnormal_ctor();
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void features_integralImageNormalEstimation_pointxyzandnormal_delete(ref IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void features_integralImageNormalEstimation_pointxyzandnormal_setRectSize(IntPtr ptr, int width, int height);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void features_integralImageNormalEstimation_pointxyzandnormal_setBorderPolicy(IntPtr ptr, BorderPolicy policy);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void features_integralImageNormalEstimation_pointxyzandnormal_setNormalEstimationMethod(IntPtr ptr, NormalEstimationMethod method);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void features_integralImageNormalEstimation_pointxyzandnormal_setMaxDepthChangeFactor(IntPtr ptr, float factor);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void features_integralImageNormalEstimation_pointxyzandnormal_setNormalSmoothingSize(IntPtr ptr, float size);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void features_integralImageNormalEstimation_pointxyzandnormal_setInputCloud(IntPtr ptr, IntPtr cloud);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void features_integralImageNormalEstimation_pointxyzandnormal_setSearchMethod(IntPtr ptr, IntPtr tree);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void features_integralImageNormalEstimation_pointxyzandnormal_setIndices(IntPtr ptr, IntPtr indices);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void features_integralImageNormalEstimation_pointxyzandnormal_compute(IntPtr ptr, IntPtr cloud);

		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void features_integralImageNormalEstimation_pointxyzandnormal_setKSearch(IntPtr ptr, int value);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern int features_integralImageNormalEstimation_pointxyzandnormal_getKSearch(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void features_integralImageNormalEstimation_pointxyzandnormal_setRadiusSearch(IntPtr ptr, double value);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern double features_integralImageNormalEstimation_pointxyzandnormal_getRadiusSearch(IntPtr ptr);
	}

	public class IntegralImageNormalEstimationPointXYZAndNormal : IntegralImageNormalEstimation<PointXYZ,Normal>
	{
		public override int KSearch 
		{ 
			get { return Invoke.features_integralImageNormalEstimation_pointxyzandnormal_getKSearch(_ptr); }
            set { Invoke.features_integralImageNormalEstimation_pointxyzandnormal_setKSearch(_ptr, value); } 
		}

        public override double RadiusSearch 
		{ 
			get { return Invoke.features_integralImageNormalEstimation_pointxyzandnormal_getRadiusSearch(_ptr); }
            set { Invoke.features_integralImageNormalEstimation_pointxyzandnormal_setRadiusSearch(_ptr, value); } 
		}

		public IntegralImageNormalEstimationPointXYZAndNormal()
		{
			_ptr = Invoke.features_integralImageNormalEstimation_pointxyzandnormal_ctor();
		}

		public override void SetRectSize(int width, int height) 
			=> Invoke.features_integralImageNormalEstimation_pointxyzandnormal_setRectSize(_ptr, width, height);

		public override void SetBorderPolicy(BorderPolicy policy) 
			=> Invoke.features_integralImageNormalEstimation_pointxyzandnormal_setBorderPolicy(_ptr, policy);

		public override void SetNormalEstimationMethod(NormalEstimationMethod method) 
			=> Invoke.features_integralImageNormalEstimation_pointxyzandnormal_setNormalEstimationMethod(_ptr, method);

		public override void SetMaxDepthChangeFactor(float factor) 
			=> Invoke.features_integralImageNormalEstimation_pointxyzandnormal_setMaxDepthChangeFactor(_ptr, factor);

		public override void SetNormalSmoothingSize(float size) 
			=> Invoke.features_integralImageNormalEstimation_pointxyzandnormal_setNormalSmoothingSize(_ptr, size);

		public override void SetInputCloud(PointCloud<PointXYZ> cloud) 
			=> Invoke.features_integralImageNormalEstimation_pointxyzandnormal_setInputCloud(_ptr, cloud.Ptr);

		public override void SetIndices(VectorOfInt indices)
			=> Invoke.features_integralImageNormalEstimation_pointxyzandnormal_setIndices(_ptr, indices);

		public void SetSearchMethod(Search<PointXYZ> tree)
			=> Invoke.features_integralImageNormalEstimation_pointxyzandnormal_setSearchMethod(_ptr, tree.Ptr);

		public override void Compute(PointCloud<Normal> cloud) 
			=> Invoke.features_integralImageNormalEstimation_pointxyzandnormal_compute(_ptr, cloud.Ptr);

		public override ref PointXYZ this[int idx]
		{
			get { return ref this.Index(idx); }
		}

		protected override void DisposeObject()
			=> Invoke.features_integralImageNormalEstimation_pointxyzandnormal_delete(ref _ptr);
	}
}

