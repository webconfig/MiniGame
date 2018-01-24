﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class UnityEngine_LineRenderer_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.LineRenderer);
            args = new Type[]{};
            method = type.GetMethod("get_startWidth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_startWidth_0);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_startWidth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_startWidth_1);
            args = new Type[]{};
            method = type.GetMethod("get_endWidth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_endWidth_2);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_endWidth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_endWidth_3);
            args = new Type[]{};
            method = type.GetMethod("get_widthCurve", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_widthCurve_4);
            args = new Type[]{typeof(UnityEngine.AnimationCurve)};
            method = type.GetMethod("set_widthCurve", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_widthCurve_5);
            args = new Type[]{};
            method = type.GetMethod("get_widthMultiplier", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_widthMultiplier_6);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_widthMultiplier", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_widthMultiplier_7);
            args = new Type[]{};
            method = type.GetMethod("get_startColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_startColor_8);
            args = new Type[]{typeof(UnityEngine.Color)};
            method = type.GetMethod("set_startColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_startColor_9);
            args = new Type[]{};
            method = type.GetMethod("get_endColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_endColor_10);
            args = new Type[]{typeof(UnityEngine.Color)};
            method = type.GetMethod("set_endColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_endColor_11);
            args = new Type[]{};
            method = type.GetMethod("get_colorGradient", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_colorGradient_12);
            args = new Type[]{typeof(UnityEngine.Gradient)};
            method = type.GetMethod("set_colorGradient", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_colorGradient_13);
            args = new Type[]{};
            method = type.GetMethod("get_positionCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_positionCount_14);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_positionCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_positionCount_15);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Vector3)};
            method = type.GetMethod("SetPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetPosition_16);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPosition_17);
            args = new Type[]{typeof(UnityEngine.Vector3[])};
            method = type.GetMethod("SetPositions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetPositions_18);
            args = new Type[]{typeof(UnityEngine.Vector3[])};
            method = type.GetMethod("GetPositions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPositions_19);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("Simplify", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Simplify_20);
            args = new Type[]{};
            method = type.GetMethod("get_useWorldSpace", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_useWorldSpace_21);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_useWorldSpace", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_useWorldSpace_22);
            args = new Type[]{};
            method = type.GetMethod("get_loop", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_loop_23);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_loop", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_loop_24);
            args = new Type[]{};
            method = type.GetMethod("get_numCornerVertices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_numCornerVertices_25);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_numCornerVertices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_numCornerVertices_26);
            args = new Type[]{};
            method = type.GetMethod("get_numCapVertices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_numCapVertices_27);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_numCapVertices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_numCapVertices_28);
            args = new Type[]{};
            method = type.GetMethod("get_textureMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_textureMode_29);
            args = new Type[]{typeof(UnityEngine.LineTextureMode)};
            method = type.GetMethod("set_textureMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_textureMode_30);
            args = new Type[]{};
            method = type.GetMethod("get_alignment", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_alignment_31);
            args = new Type[]{typeof(UnityEngine.LineAlignment)};
            method = type.GetMethod("set_alignment", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_alignment_32);
            args = new Type[]{};
            method = type.GetMethod("get_generateLightingData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_generateLightingData_33);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_generateLightingData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_generateLightingData_34);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.LineRenderer());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.LineRenderer[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_startWidth_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.startWidth;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_startWidth_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.startWidth = value;

            return __ret;
        }

        static StackObject* get_endWidth_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.endWidth;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_endWidth_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.endWidth = value;

            return __ret;
        }

        static StackObject* get_widthCurve_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.widthCurve;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_widthCurve_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AnimationCurve value = (UnityEngine.AnimationCurve)typeof(UnityEngine.AnimationCurve).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.widthCurve = value;

            return __ret;
        }

        static StackObject* get_widthMultiplier_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.widthMultiplier;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_widthMultiplier_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.widthMultiplier = value;

            return __ret;
        }

        static StackObject* get_startColor_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.startColor;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_startColor_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color value = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.startColor = value;

            return __ret;
        }

        static StackObject* get_endColor_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.endColor;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_endColor_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color value = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.endColor = value;

            return __ret;
        }

        static StackObject* get_colorGradient_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.colorGradient;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_colorGradient_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Gradient value = (UnityEngine.Gradient)typeof(UnityEngine.Gradient).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.colorGradient = value;

            return __ret;
        }

        static StackObject* get_positionCount_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.positionCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_positionCount_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.positionCount = value;

            return __ret;
        }

        static StackObject* SetPosition_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetPosition(index, position);

            return __ret;
        }

        static StackObject* GetPosition_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPosition(index);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetPositions_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3[] positions = (UnityEngine.Vector3[])typeof(UnityEngine.Vector3[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetPositions(positions);

            return __ret;
        }

        static StackObject* GetPositions_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3[] positions = (UnityEngine.Vector3[])typeof(UnityEngine.Vector3[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPositions(positions);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Simplify_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single tolerance = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Simplify(tolerance);

            return __ret;
        }

        static StackObject* get_useWorldSpace_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.useWorldSpace;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_useWorldSpace_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.useWorldSpace = value;

            return __ret;
        }

        static StackObject* get_loop_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.loop;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_loop_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.loop = value;

            return __ret;
        }

        static StackObject* get_numCornerVertices_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.numCornerVertices;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_numCornerVertices_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.numCornerVertices = value;

            return __ret;
        }

        static StackObject* get_numCapVertices_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.numCapVertices;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_numCapVertices_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.numCapVertices = value;

            return __ret;
        }

        static StackObject* get_textureMode_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.textureMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_textureMode_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LineTextureMode value = (UnityEngine.LineTextureMode)typeof(UnityEngine.LineTextureMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.textureMode = value;

            return __ret;
        }

        static StackObject* get_alignment_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.alignment;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_alignment_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LineAlignment value = (UnityEngine.LineAlignment)typeof(UnityEngine.LineAlignment).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.alignment = value;

            return __ret;
        }

        static StackObject* get_generateLightingData_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.generateLightingData;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_generateLightingData_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LineRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.LineRenderer)typeof(UnityEngine.LineRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.generateLightingData = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.LineRenderer();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
