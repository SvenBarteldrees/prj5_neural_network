﻿//----------------------------------------------------------------------------
//
//  Copyright (C) 2004-2017 by EMGU Corporation. All rights reserved.
//
//  Vector of ERStat
//
//  This file is automatically generated, do not modify.
//----------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Diagnostics;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Emgu.CV.Structure;
#if !(NETFX_CORE || NETCOREAPP1_1 || NETSTANDARD1_4)
using System.Runtime.Serialization;
#endif

namespace Emgu.CV.Text
{
   /// <summary>
   /// Wrapped class of the C++ standard vector of ERStat.
   /// </summary>
#if !(NETFX_CORE || NETCOREAPP1_1 || NETSTANDARD1_4)
   [Serializable]
   [DebuggerTypeProxy(typeof(VectorOfERStat.DebuggerProxy))]
#endif
   public partial class VectorOfERStat : Emgu.Util.UnmanagedObject, IInputOutputArray
#if !(NETFX_CORE || NETCOREAPP1_1 || NETSTANDARD1_4)
   , ISerializable
#endif
   {
      private readonly bool _needDispose;
   
      static VectorOfERStat()
      {
         CvInvoke.CheckLibraryLoaded();
         Debug.Assert(Emgu.Util.Toolbox.SizeOf<MCvERStat>() == SizeOfItemInBytes, "Size do not match");
      }

#if !(NETFX_CORE || NETCOREAPP1_1 || NETSTANDARD1_4)
      /// <summary>
      /// Constructor used to deserialize runtime serialized object
      /// </summary>
      /// <param name="info">The serialization info</param>
      /// <param name="context">The streaming context</param>
      public VectorOfERStat(SerializationInfo info, StreamingContext context)
         : this()
      {
         Push((MCvERStat[])info.GetValue("ERStatArray", typeof(MCvERStat[])));
      }
	  
	   /// <summary>
      /// A function used for runtime serialization of the object
      /// </summary>
      /// <param name="info">Serialization info</param>
      /// <param name="context">Streaming context</param>
      public void GetObjectData(SerializationInfo info, StreamingContext context)
      {
         info.AddValue("ERStatArray", ToArray());
      }
#endif

      /// <summary>
      /// Create an empty standard vector of ERStat
      /// </summary>
      public VectorOfERStat()
         : this(VectorOfERStatCreate(), true)
      {
      }
	  
	   internal VectorOfERStat(IntPtr ptr, bool needDispose)
      {
         _ptr = ptr;
         _needDispose = needDispose;
      }

      /// <summary>
      /// Create an standard vector of ERStat of the specific size
      /// </summary>
      /// <param name="size">The size of the vector</param>
      public VectorOfERStat(int size)
         : this( VectorOfERStatCreateSize(size), true)
      {
      }
	  
	   /// <summary>
      /// Create an standard vector of ERStat with the initial values
      /// </summary>
      /// <param name="values">The initial values</param>
	   public VectorOfERStat(MCvERStat[] values)
         :this()
      {
         Push(values);
      }
	  
      /// <summary>
      /// Push an array of value into the standard vector
      /// </summary>
      /// <param name="value">The value to be pushed to the vector</param>
      public void Push(MCvERStat[] value)
      {
         if (value.Length > 0)
         {
            GCHandle handle = GCHandle.Alloc(value, GCHandleType.Pinned);
            VectorOfERStatPushMulti(_ptr, handle.AddrOfPinnedObject(), value.Length);
            handle.Free();
         }
      }
      
      /// <summary>
      /// Push multiple values from the other vector into this vector
      /// </summary>
      /// <param name="other">The other vector, from which the values will be pushed to the current vector</param>
      public void Push(VectorOfERStat other)
      {
         VectorOfERStatPushVector(_ptr, other);
      }
	  
	   /// <summary>
      /// Convert the standard vector to an array of ERStat
      /// </summary>
      /// <returns>An array of ERStat</returns>
      public MCvERStat[] ToArray()
      {
         MCvERStat[] res = new MCvERStat[Size];
         if (res.Length > 0)
         {
            GCHandle handle = GCHandle.Alloc(res, GCHandleType.Pinned);
            VectorOfERStatCopyData(_ptr, handle.AddrOfPinnedObject());
            handle.Free();
         }
         return res;
      }

      /// <summary>
      /// Get the size of the vector
      /// </summary>
      public int Size
      {
         get
         {
            return VectorOfERStatGetSize(_ptr);
         }
      }

      /// <summary>
      /// Clear the vector
      /// </summary>
      public void Clear()
      {
         VectorOfERStatClear(_ptr);
      }

      /// <summary>
      /// The pointer to the first element on the vector. In case of an empty vector, IntPtr.Zero will be returned.
      /// </summary>
      public IntPtr StartAddress
      {
         get
         {
            return VectorOfERStatGetStartAddress(_ptr);
         }
      }
	  
	   /// <summary>
      /// Get the item in the specific index
      /// </summary>
      /// <param name="index">The index</param>
      /// <returns>The item in the specific index</returns>
      public MCvERStat this[int index]
      {
         get
         {
            MCvERStat result = new MCvERStat();
            VectorOfERStatGetItem(_ptr, index, ref result);
            return result;
         }
      }

      /// <summary>
      /// Release the standard vector
      /// </summary>
      protected override void DisposeObject()
      {
         if (_needDispose && _ptr != IntPtr.Zero)
            VectorOfERStatRelease(ref _ptr);
      }

	   /// <summary>
      /// Get the pointer to cv::_InputArray
      /// </summary>
      public InputArray GetInputArray()
      {
         return new InputArray( cvInputArrayFromVectorOfERStat(_ptr), this );
      }
	  
	   /// <summary>
      /// Get the pointer to cv::_OutputArray
      /// </summary>
      public OutputArray GetOutputArray()
      {
         return new OutputArray( cvOutputArrayFromVectorOfERStat(_ptr), this );
      }

	   /// <summary>
      /// Get the pointer to cv::_InputOutputArray
      /// </summary>
      public InputOutputArray GetInputOutputArray()
      {
         return new InputOutputArray( cvInputOutputArrayFromVectorOfERStat(_ptr), this );
      }
      
      /// <summary>
      /// The size of the item in this Vector, counted as size in bytes.
      /// </summary>
      public static int SizeOfItemInBytes
      {
         get { return VectorOfERStatSizeOfItemInBytes(); }
      }
	  
      internal class DebuggerProxy
      {
         private VectorOfERStat _v;

         public DebuggerProxy(VectorOfERStat v)
         {
            _v = v;
         }

         public MCvERStat[] Values
         {
            get { return _v.ToArray(); }
         }
      }

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr VectorOfERStatCreate();

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr VectorOfERStatCreateSize(int size);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfERStatRelease(ref IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern int VectorOfERStatGetSize(IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfERStatCopyData(IntPtr v, IntPtr data);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr VectorOfERStatGetStartAddress(IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfERStatPushMulti(IntPtr v, IntPtr values, int count);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfERStatPushVector(IntPtr ptr, IntPtr otherPtr);
      
      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfERStatClear(IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfERStatGetItem(IntPtr vec, int index, ref MCvERStat element);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern int VectorOfERStatSizeOfItemInBytes();
      
      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr cvInputArrayFromVectorOfERStat(IntPtr vec);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr cvOutputArrayFromVectorOfERStat(IntPtr vec);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr cvInputOutputArrayFromVectorOfERStat(IntPtr vec);
   }
}
