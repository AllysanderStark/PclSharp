
// Code generated by a template
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using PclSharp.Struct;
using PclSharp.Std;
using PclSharp.Search;	

namespace PclSharp.Features
{
	public static partial class Invoke
	{
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern IntPtr features_normalEstimation_pointxyzandnormal_ctor();
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void features_normalEstimation_pointxyzandnormal_delete(ref IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void features_normalEstimation_pointxyzandnormal_setInputCloud(IntPtr ptr, IntPtr cloud);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void features_normalEstimation_pointxyzandnormal_setSearchMethod(IntPtr ptr, IntPtr tree);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void features_normalEstimation_pointxyzandnormal_setIndices(IntPtr ptr, IntPtr indices);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void features_normalEstimation_pointxyzandnormal_compute(IntPtr ptr, IntPtr cloud);

		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void features_normalEstimation_pointxyzandnormal_setKSearch(IntPtr ptr, int value);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern int features_normalEstimation_pointxyzandnormal_getKSearch(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void features_normalEstimation_pointxyzandnormal_setRadiusSearch(IntPtr ptr, double value);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern double features_normalEstimation_pointxyzandnormal_getRadiusSearch(IntPtr ptr);
	}

	public class NormalEstimationPointXYZAndNormal : Feature<PointXYZ,Normal>
	{
		public override int KSearch 
		{ 
			get { return Invoke.features_normalEstimation_pointxyzandnormal_getKSearch(_ptr); }
            set { Invoke.features_normalEstimation_pointxyzandnormal_setKSearch(_ptr, value); } 
		}

        public override double RadiusSearch 
		{ 
			get { return Invoke.features_normalEstimation_pointxyzandnormal_getRadiusSearch(_ptr); }
            set { Invoke.features_normalEstimation_pointxyzandnormal_setRadiusSearch(_ptr, value); } 
		}

		public NormalEstimationPointXYZAndNormal()
		{
			_ptr = Invoke.features_normalEstimation_pointxyzandnormal_ctor();
		}

		public override void SetInputCloud(PointCloud<PointXYZ> cloud) 
			=> Invoke.features_normalEstimation_pointxyzandnormal_setInputCloud(_ptr, cloud.Ptr);

		public override void SetIndices(VectorOfInt indices)
			=> Invoke.features_normalEstimation_pointxyzandnormal_setIndices(_ptr, indices);

		public void SetSearchMethod(Search<PointXYZ> tree)
			=> Invoke.features_normalEstimation_pointxyzandnormal_setSearchMethod(_ptr, tree.Ptr);

		public override void Compute(PointCloud<Normal> cloud) 
			=> Invoke.features_normalEstimation_pointxyzandnormal_compute(_ptr, cloud.Ptr);

		public override ref PointXYZ this[int idx]
		{
			get { return ref this.Index(idx); }
		}

		protected override void DisposeObject()
			=> Invoke.features_normalEstimation_pointxyzandnormal_delete(ref _ptr);
	}
}

