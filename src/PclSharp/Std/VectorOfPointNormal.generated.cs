
// Code generated by a template
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Numerics;
using PclSharp.Struct;


namespace PclSharp.Std
{
	public static partial class Invoke
	{
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern IntPtr std_vector_pointnormal_ctor();
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern IntPtr std_vector_pointnormal_ctor_count(int count);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void std_vector_pointnormal_delete(ref IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void std_vector_pointnormal_at(IntPtr ptr,  UIntPtr idx, ref PointNormal value);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern UIntPtr std_vector_pointnormal_size(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void std_vector_pointnormal_clear(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void std_vector_pointnormal_resize(IntPtr ptr, int size);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void std_vector_pointnormal_add(IntPtr ptr, PointNormal value);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern IntPtr std_vector_pointnormal_data(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void std_vector_pointnormal_insert(IntPtr ptr, IntPtr idx, PointNormal value);
	}

	public unsafe class VectorOfPointNormal : Vector<PointNormal>
	{	
		private bool _suppressDispose;

		public override int Count => (int)Invoke.std_vector_pointnormal_size(_ptr);
		public IntPtr Data => Invoke.std_vector_pointnormal_data(_ptr);
		public PointNormal* DataU => (PointNormal*)Data;

		public VectorOfPointNormal()
		{
			_ptr = Invoke.std_vector_pointnormal_ctor();
		}

		public VectorOfPointNormal(int count)
		{
			_ptr = Invoke.std_vector_pointnormal_ctor_count(count);
		}

		/// <summary>
        /// construct as a copy of the list
        /// </summary>
        /// <param name="list"></param>
		public VectorOfPointNormal(List<PointNormal> list)
        {
            var arr = list.ToArray();
            _ptr = Invoke.std_vector_pointnormal_ctor_count(arr.Length);
            
            var dptr = (PointNormal*)Data;
            for(var i = 0; i < arr.Length; i++)
                dptr[i] = arr[i];
        }

		internal VectorOfPointNormal(IntPtr ptr)
		{
			_suppressDispose = true;
			_ptr = ptr;
		}

		public override void At(int idx, ref PointNormal value)
		{
			Invoke.std_vector_pointnormal_at(_ptr, (UIntPtr)idx, ref value);
		}

		public override PointNormal this[int idx]
        {
            get { return DataU[idx]; }
			set { DataU[idx] = value; }
		}

		public override void Resize(int size)
			=> Invoke.std_vector_pointnormal_resize(_ptr, size);

		public override void Add(PointNormal value)
			=> Invoke.std_vector_pointnormal_add(_ptr, value);

		public override void CopyTo(PointNormal[] arr, int idx)
		{
            fixed (PointNormal* aptr = arr)
            {
                Unsafe.CopyBlockUnaligned(aptr, DataU, (uint)(sizeof(PointNormal) * Count));
            }
		}

		public override PointNormal[] ToArray()
		{
			var arr = new PointNormal[Count];
            fixed (PointNormal* aptr = arr)
            {
                Unsafe.CopyBlockUnaligned(aptr, DataU, (uint)(sizeof(PointNormal) * arr.Length));
            }

			return arr;
		}

		public override void Clear() => Invoke.std_vector_pointnormal_clear(_ptr);

		public override void Insert(int index, PointNormal item)
			=> Invoke.std_vector_pointnormal_insert(_ptr, (IntPtr)index, item);

		public override IEnumerator<PointNormal> GetEnumerator()
		{
			var count = Count;
			for(var i = 0; i < count; i++)
				yield return this[i];
		}

		protected override void DisposeObject()
		{
			if (_suppressDispose)
				return;
			Invoke.std_vector_pointnormal_delete(ref _ptr);
		}
	}
}