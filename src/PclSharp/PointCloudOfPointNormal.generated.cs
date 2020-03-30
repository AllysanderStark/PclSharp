
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
		public static extern IntPtr pointcloud_pointnormal_ctor();
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern IntPtr pointcloud_pointnormal_ctor_indices(IntPtr cloud, IntPtr indices);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern IntPtr pointcloud_pointnormal_ctor_wh(uint width, uint height);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void pointcloud_pointnormal_delete(ref IntPtr ptr);
		//methods
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern unsafe PointNormal* pointcloud_pointnormal_at_colrow(IntPtr ptr, int col, int row);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void pointcloud_pointnormal_clear(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern unsafe void pointcloud_pointnormal_add(IntPtr ptr, PointNormal* value);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void pointcloud_pointnormal_downsample(IntPtr ptr, int factor, IntPtr output);
		//properties
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern UIntPtr pointcloud_pointnormal_size(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern IntPtr pointcloud_pointnormal_data(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern uint pointcloud_pointnormal_width(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void pointcloud_pointnormal_width_set(IntPtr ptr, uint width);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern uint pointcloud_pointnormal_height(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void pointcloud_pointnormal_height_set(IntPtr ptr, uint height);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern IntPtr pointcloud_pointnormal_points(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void pointcloud_pointnormal_setIsDense(IntPtr ptr, bool value);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern bool pointcloud_pointnormal_getIsDense(IntPtr ptr);
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern bool pointcloud_pointnormal_isOrganized(IntPtr ptr);
	}

	public unsafe class PointCloudOfPointNormal : PointCloud<PointNormal>
	{
		private bool _suppressDispose;

		public override int Width 
		{
			get { return (int)Invoke.pointcloud_pointnormal_width(_ptr); }
			set { Invoke.pointcloud_pointnormal_width_set(_ptr, (uint)value); }
		}
		public override int Height 
		{
			get { return (int)Invoke.pointcloud_pointnormal_height(_ptr); }
			set { Invoke.pointcloud_pointnormal_height_set(_ptr, (uint)value); }
		}
		public override bool IsDense
		{
			get { return Invoke.pointcloud_pointnormal_getIsDense(_ptr); }
            set { Invoke.pointcloud_pointnormal_setIsDense(_ptr, value); }
		}
		public override int Count => (int)Invoke.pointcloud_pointnormal_size(_ptr);
		public int Size => Count;
		public override bool IsOrganized => Invoke.pointcloud_pointnormal_isOrganized(_ptr);
		public PointNormal* Data => (PointNormal*)Invoke.pointcloud_pointnormal_data(_ptr);

		private VectorOfPointNormal _points;
		public override Vector<PointNormal> Points => _points;

		private PointCloudOfPointNormal(IntPtr ptr)
		{
			_ptr = ptr;
			_points = new VectorOfPointNormal(Invoke.pointcloud_pointnormal_points(_ptr));
		}

		internal PointCloudOfPointNormal(IntPtr ptr, bool suppressDispose)
			:this(ptr)
		{
			_suppressDispose = suppressDispose;
		}

		public PointCloudOfPointNormal() 
			: this(Invoke.pointcloud_pointnormal_ctor())
		{
		}

		public PointCloudOfPointNormal(int width, int height)
			: this(Invoke.pointcloud_pointnormal_ctor_wh((uint)width, (uint)height))
		{
		}

		public PointCloudOfPointNormal(PointCloudOfPointNormal cloud, Std.VectorOfInt indices)
			:this (Invoke.pointcloud_pointnormal_ctor_indices(cloud.Ptr, indices.Ptr))
		{
		}

		public void Downsample(int factor, PointCloud<PointNormal> output)
			=> Invoke.pointcloud_pointnormal_downsample(_ptr, factor, output);

		public override ref PointNormal At(int col, int row)
			=>  ref Unsafe.AsRef<PointNormal>(Invoke.pointcloud_pointnormal_at_colrow(_ptr, col, row));

		public override void Add(PointNormal value)
			=> Invoke.pointcloud_pointnormal_add(_ptr, &value);

		protected override void DisposeObject()
		{
			if (_suppressDispose)
				return;
			Invoke.pointcloud_pointnormal_delete(ref _ptr);
		}
	}
}
