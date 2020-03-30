
// Code generated by a template
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using PclSharp.Struct;
using PclSharp.Std;
using System.Runtime.CompilerServices;

namespace PclSharp
{
	public static partial class Invoke
	{
		//ctor/dctor
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern IntPtr pointcloud_xyzl_ctor();
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern IntPtr pointcloud_xyzl_ctor_indices(IntPtr cloud, IntPtr indices);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern IntPtr pointcloud_xyzl_ctor_wh(uint width, uint height);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void pointcloud_xyzl_delete(ref IntPtr ptr);
		//methods
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern unsafe PointXYZL* pointcloud_xyzl_at_colrow(IntPtr ptr, int col, int row);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void pointcloud_xyzl_clear(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern unsafe void pointcloud_xyzl_add(IntPtr ptr, PointXYZL* value);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void pointcloud_xyzl_downsample(IntPtr ptr, int factor, IntPtr output);
		//properties
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern UIntPtr pointcloud_xyzl_size(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern IntPtr pointcloud_xyzl_data(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern uint pointcloud_xyzl_width(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void pointcloud_xyzl_width_set(IntPtr ptr, uint width);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern uint pointcloud_xyzl_height(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void pointcloud_xyzl_height_set(IntPtr ptr, uint height);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern IntPtr pointcloud_xyzl_points(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void pointcloud_xyzl_setIsDense(IntPtr ptr, bool value);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern bool pointcloud_xyzl_getIsDense(IntPtr ptr);
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern bool pointcloud_xyzl_isOrganized(IntPtr ptr);
	}

	public unsafe class PointCloudOfXYZL : PointCloud<PointXYZL>
	{
		private bool _suppressDispose;

		public override int Width 
		{
			get { return (int)Invoke.pointcloud_xyzl_width(_ptr); }
			set { Invoke.pointcloud_xyzl_width_set(_ptr, (uint)value); }
		}
		public override int Height 
		{
			get { return (int)Invoke.pointcloud_xyzl_height(_ptr); }
			set { Invoke.pointcloud_xyzl_height_set(_ptr, (uint)value); }
		}
		public override bool IsDense
		{
			get { return Invoke.pointcloud_xyzl_getIsDense(_ptr); }
            set { Invoke.pointcloud_xyzl_setIsDense(_ptr, value); }
		}
		public override int Count => (int)Invoke.pointcloud_xyzl_size(_ptr);
		public int Size => Count;
		public override bool IsOrganized => Invoke.pointcloud_xyzl_isOrganized(_ptr);
		public PointXYZL* Data => (PointXYZL*)Invoke.pointcloud_xyzl_data(_ptr);

		private VectorOfXYZL _points;
		public override Vector<PointXYZL> Points => _points;

		private PointCloudOfXYZL(IntPtr ptr)
		{
			_ptr = ptr;
			_points = new VectorOfXYZL(Invoke.pointcloud_xyzl_points(_ptr));
		}

		internal PointCloudOfXYZL(IntPtr ptr, bool suppressDispose)
			:this(ptr)
		{
			_suppressDispose = suppressDispose;
		}

		public PointCloudOfXYZL() 
			: this(Invoke.pointcloud_xyzl_ctor())
		{
		}

		public PointCloudOfXYZL(int width, int height)
			: this(Invoke.pointcloud_xyzl_ctor_wh((uint)width, (uint)height))
		{
		}

		public PointCloudOfXYZL(PointCloudOfXYZL cloud, Std.VectorOfInt indices)
			:this (Invoke.pointcloud_xyzl_ctor_indices(cloud.Ptr, indices.Ptr))
		{
		}

		public void Downsample(int factor, PointCloud<PointXYZL> output)
			=> Invoke.pointcloud_xyzl_downsample(_ptr, factor, output);

		public override ref PointXYZL At(int col, int row)
			=>  ref Unsafe.AsRef<PointXYZL>(Invoke.pointcloud_xyzl_at_colrow(_ptr, col, row));

		public override void Add(PointXYZL value)
			=> Invoke.pointcloud_xyzl_add(_ptr, &value);

		protected override void DisposeObject()
		{
			if (_suppressDispose)
				return;
			Invoke.pointcloud_xyzl_delete(ref _ptr);
		}
	}
}
