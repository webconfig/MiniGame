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
    unsafe class UnityEngine_Animator_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Animator);
            args = new Type[]{};
            method = type.GetMethod("get_isOptimizable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isOptimizable_0);
            args = new Type[]{};
            method = type.GetMethod("get_isHuman", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isHuman_1);
            args = new Type[]{};
            method = type.GetMethod("get_hasRootMotion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hasRootMotion_2);
            args = new Type[]{};
            method = type.GetMethod("get_humanScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_humanScale_3);
            args = new Type[]{};
            method = type.GetMethod("get_isInitialized", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isInitialized_4);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetFloat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetFloat_5);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetFloat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetFloat_6);
            args = new Type[]{typeof(System.String), typeof(System.Single)};
            method = type.GetMethod("SetFloat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetFloat_7);
            args = new Type[]{typeof(System.String), typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("SetFloat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetFloat_8);
            args = new Type[]{typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("SetFloat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetFloat_9);
            args = new Type[]{typeof(System.Int32), typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("SetFloat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetFloat_10);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetBool", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBool_11);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetBool", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBool_12);
            args = new Type[]{typeof(System.String), typeof(System.Boolean)};
            method = type.GetMethod("SetBool", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetBool_13);
            args = new Type[]{typeof(System.Int32), typeof(System.Boolean)};
            method = type.GetMethod("SetBool", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetBool_14);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetInteger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetInteger_15);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetInteger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetInteger_16);
            args = new Type[]{typeof(System.String), typeof(System.Int32)};
            method = type.GetMethod("SetInteger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetInteger_17);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("SetInteger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetInteger_18);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("SetTrigger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetTrigger_19);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("SetTrigger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetTrigger_20);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("ResetTrigger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ResetTrigger_21);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("ResetTrigger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ResetTrigger_22);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("IsParameterControlledByCurve", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsParameterControlledByCurve_23);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("IsParameterControlledByCurve", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsParameterControlledByCurve_24);
            args = new Type[]{};
            method = type.GetMethod("get_deltaPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_deltaPosition_25);
            args = new Type[]{};
            method = type.GetMethod("get_deltaRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_deltaRotation_26);
            args = new Type[]{};
            method = type.GetMethod("get_velocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_velocity_27);
            args = new Type[]{};
            method = type.GetMethod("get_angularVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_angularVelocity_28);
            args = new Type[]{};
            method = type.GetMethod("get_rootPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_rootPosition_29);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_rootPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_rootPosition_30);
            args = new Type[]{};
            method = type.GetMethod("get_rootRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_rootRotation_31);
            args = new Type[]{typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("set_rootRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_rootRotation_32);
            args = new Type[]{};
            method = type.GetMethod("get_applyRootMotion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_applyRootMotion_33);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_applyRootMotion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_applyRootMotion_34);
            args = new Type[]{};
            method = type.GetMethod("get_linearVelocityBlending", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_linearVelocityBlending_35);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_linearVelocityBlending", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_linearVelocityBlending_36);
            args = new Type[]{};
            method = type.GetMethod("get_updateMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_updateMode_37);
            args = new Type[]{typeof(UnityEngine.AnimatorUpdateMode)};
            method = type.GetMethod("set_updateMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_updateMode_38);
            args = new Type[]{};
            method = type.GetMethod("get_hasTransformHierarchy", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hasTransformHierarchy_39);
            args = new Type[]{};
            method = type.GetMethod("get_gravityWeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_gravityWeight_40);
            args = new Type[]{};
            method = type.GetMethod("get_bodyPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_bodyPosition_41);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_bodyPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_bodyPosition_42);
            args = new Type[]{};
            method = type.GetMethod("get_bodyRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_bodyRotation_43);
            args = new Type[]{typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("set_bodyRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_bodyRotation_44);
            args = new Type[]{typeof(UnityEngine.AvatarIKGoal)};
            method = type.GetMethod("GetIKPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetIKPosition_45);
            args = new Type[]{typeof(UnityEngine.AvatarIKGoal), typeof(UnityEngine.Vector3)};
            method = type.GetMethod("SetIKPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetIKPosition_46);
            args = new Type[]{typeof(UnityEngine.AvatarIKGoal)};
            method = type.GetMethod("GetIKRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetIKRotation_47);
            args = new Type[]{typeof(UnityEngine.AvatarIKGoal), typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("SetIKRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetIKRotation_48);
            args = new Type[]{typeof(UnityEngine.AvatarIKGoal)};
            method = type.GetMethod("GetIKPositionWeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetIKPositionWeight_49);
            args = new Type[]{typeof(UnityEngine.AvatarIKGoal), typeof(System.Single)};
            method = type.GetMethod("SetIKPositionWeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetIKPositionWeight_50);
            args = new Type[]{typeof(UnityEngine.AvatarIKGoal)};
            method = type.GetMethod("GetIKRotationWeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetIKRotationWeight_51);
            args = new Type[]{typeof(UnityEngine.AvatarIKGoal), typeof(System.Single)};
            method = type.GetMethod("SetIKRotationWeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetIKRotationWeight_52);
            args = new Type[]{typeof(UnityEngine.AvatarIKHint)};
            method = type.GetMethod("GetIKHintPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetIKHintPosition_53);
            args = new Type[]{typeof(UnityEngine.AvatarIKHint), typeof(UnityEngine.Vector3)};
            method = type.GetMethod("SetIKHintPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetIKHintPosition_54);
            args = new Type[]{typeof(UnityEngine.AvatarIKHint)};
            method = type.GetMethod("GetIKHintPositionWeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetIKHintPositionWeight_55);
            args = new Type[]{typeof(UnityEngine.AvatarIKHint), typeof(System.Single)};
            method = type.GetMethod("SetIKHintPositionWeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetIKHintPositionWeight_56);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("SetLookAtPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetLookAtPosition_57);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("SetLookAtWeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetLookAtWeight_58);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("SetLookAtWeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetLookAtWeight_59);
            args = new Type[]{typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("SetLookAtWeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetLookAtWeight_60);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("SetLookAtWeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetLookAtWeight_61);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("SetLookAtWeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetLookAtWeight_62);
            args = new Type[]{typeof(UnityEngine.HumanBodyBones), typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("SetBoneLocalRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetBoneLocalRotation_63);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("GetBehaviours", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBehaviours_64);
            args = new Type[]{};
            method = type.GetMethod("get_stabilizeFeet", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_stabilizeFeet_65);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_stabilizeFeet", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_stabilizeFeet_66);
            args = new Type[]{};
            method = type.GetMethod("get_layerCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_layerCount_67);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetLayerName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetLayerName_68);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetLayerIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetLayerIndex_69);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetLayerWeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetLayerWeight_70);
            args = new Type[]{typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("SetLayerWeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetLayerWeight_71);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetCurrentAnimatorStateInfo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetCurrentAnimatorStateInfo_72);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetNextAnimatorStateInfo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetNextAnimatorStateInfo_73);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetAnimatorTransitionInfo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAnimatorTransitionInfo_74);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetCurrentAnimatorClipInfoCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetCurrentAnimatorClipInfoCount_75);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetCurrentAnimatorClipInfo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetCurrentAnimatorClipInfo_76);
            args = new Type[]{typeof(System.Int32), typeof(System.Collections.Generic.List<UnityEngine.AnimatorClipInfo>)};
            method = type.GetMethod("GetCurrentAnimatorClipInfo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetCurrentAnimatorClipInfo_77);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetNextAnimatorClipInfoCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetNextAnimatorClipInfoCount_78);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetNextAnimatorClipInfo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetNextAnimatorClipInfo_79);
            args = new Type[]{typeof(System.Int32), typeof(System.Collections.Generic.List<UnityEngine.AnimatorClipInfo>)};
            method = type.GetMethod("GetNextAnimatorClipInfo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetNextAnimatorClipInfo_80);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("IsInTransition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsInTransition_81);
            args = new Type[]{};
            method = type.GetMethod("get_parameters", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_parameters_82);
            args = new Type[]{};
            method = type.GetMethod("get_parameterCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_parameterCount_83);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetParameter", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetParameter_84);
            args = new Type[]{};
            method = type.GetMethod("get_feetPivotActive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_feetPivotActive_85);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_feetPivotActive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_feetPivotActive_86);
            args = new Type[]{};
            method = type.GetMethod("get_pivotWeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_pivotWeight_87);
            args = new Type[]{};
            method = type.GetMethod("get_pivotPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_pivotPosition_88);
            args = new Type[]{typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.AvatarTarget), typeof(UnityEngine.MatchTargetWeightMask), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("MatchTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MatchTarget_89);
            args = new Type[]{typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.AvatarTarget), typeof(UnityEngine.MatchTargetWeightMask), typeof(System.Single)};
            method = type.GetMethod("MatchTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MatchTarget_90);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("InterruptMatchTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, InterruptMatchTarget_91);
            args = new Type[]{};
            method = type.GetMethod("InterruptMatchTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, InterruptMatchTarget_92);
            args = new Type[]{};
            method = type.GetMethod("get_isMatchingTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isMatchingTarget_93);
            args = new Type[]{};
            method = type.GetMethod("get_speed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_speed_94);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_speed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_speed_95);
            args = new Type[]{typeof(System.String), typeof(System.Single), typeof(System.Int32)};
            method = type.GetMethod("CrossFadeInFixedTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CrossFadeInFixedTime_96);
            args = new Type[]{typeof(System.String), typeof(System.Single)};
            method = type.GetMethod("CrossFadeInFixedTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CrossFadeInFixedTime_97);
            args = new Type[]{typeof(System.String), typeof(System.Single), typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("CrossFadeInFixedTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CrossFadeInFixedTime_98);
            args = new Type[]{typeof(System.Int32), typeof(System.Single), typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("CrossFadeInFixedTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CrossFadeInFixedTime_99);
            args = new Type[]{typeof(System.Int32), typeof(System.Single), typeof(System.Int32)};
            method = type.GetMethod("CrossFadeInFixedTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CrossFadeInFixedTime_100);
            args = new Type[]{typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("CrossFadeInFixedTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CrossFadeInFixedTime_101);
            args = new Type[]{typeof(System.String), typeof(System.Single), typeof(System.Int32)};
            method = type.GetMethod("CrossFade", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CrossFade_102);
            args = new Type[]{typeof(System.String), typeof(System.Single)};
            method = type.GetMethod("CrossFade", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CrossFade_103);
            args = new Type[]{typeof(System.String), typeof(System.Single), typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("CrossFade", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CrossFade_104);
            args = new Type[]{typeof(System.Int32), typeof(System.Single), typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("CrossFade", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CrossFade_105);
            args = new Type[]{typeof(System.Int32), typeof(System.Single), typeof(System.Int32)};
            method = type.GetMethod("CrossFade", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CrossFade_106);
            args = new Type[]{typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("CrossFade", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CrossFade_107);
            args = new Type[]{typeof(System.String), typeof(System.Int32)};
            method = type.GetMethod("PlayInFixedTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PlayInFixedTime_108);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("PlayInFixedTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PlayInFixedTime_109);
            args = new Type[]{typeof(System.String), typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("PlayInFixedTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PlayInFixedTime_110);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("PlayInFixedTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PlayInFixedTime_111);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("PlayInFixedTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PlayInFixedTime_112);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("PlayInFixedTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PlayInFixedTime_113);
            args = new Type[]{typeof(System.String), typeof(System.Int32)};
            method = type.GetMethod("Play", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Play_114);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("Play", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Play_115);
            args = new Type[]{typeof(System.String), typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("Play", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Play_116);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("Play", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Play_117);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("Play", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Play_118);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("Play", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Play_119);
            args = new Type[]{typeof(UnityEngine.AvatarTarget), typeof(System.Single)};
            method = type.GetMethod("SetTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetTarget_120);
            args = new Type[]{};
            method = type.GetMethod("get_targetPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_targetPosition_121);
            args = new Type[]{};
            method = type.GetMethod("get_targetRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_targetRotation_122);
            args = new Type[]{typeof(UnityEngine.HumanBodyBones)};
            method = type.GetMethod("GetBoneTransform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBoneTransform_123);
            args = new Type[]{};
            method = type.GetMethod("get_cullingMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_cullingMode_124);
            args = new Type[]{typeof(UnityEngine.AnimatorCullingMode)};
            method = type.GetMethod("set_cullingMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_cullingMode_125);
            args = new Type[]{};
            method = type.GetMethod("StartPlayback", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StartPlayback_126);
            args = new Type[]{};
            method = type.GetMethod("StopPlayback", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StopPlayback_127);
            args = new Type[]{};
            method = type.GetMethod("get_playbackTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_playbackTime_128);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_playbackTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_playbackTime_129);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("StartRecording", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StartRecording_130);
            args = new Type[]{};
            method = type.GetMethod("StopRecording", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StopRecording_131);
            args = new Type[]{};
            method = type.GetMethod("get_recorderStartTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_recorderStartTime_132);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_recorderStartTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_recorderStartTime_133);
            args = new Type[]{};
            method = type.GetMethod("get_recorderStopTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_recorderStopTime_134);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_recorderStopTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_recorderStopTime_135);
            args = new Type[]{};
            method = type.GetMethod("get_recorderMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_recorderMode_136);
            args = new Type[]{};
            method = type.GetMethod("get_runtimeAnimatorController", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_runtimeAnimatorController_137);
            args = new Type[]{typeof(UnityEngine.RuntimeAnimatorController)};
            method = type.GetMethod("set_runtimeAnimatorController", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_runtimeAnimatorController_138);
            args = new Type[]{};
            method = type.GetMethod("get_hasBoundPlayables", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hasBoundPlayables_139);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("HasState", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, HasState_140);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("StringToHash", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StringToHash_141);
            args = new Type[]{};
            method = type.GetMethod("get_avatar", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_avatar_142);
            args = new Type[]{typeof(UnityEngine.Avatar)};
            method = type.GetMethod("set_avatar", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_avatar_143);
            args = new Type[]{};
            method = type.GetMethod("get_playableGraph", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_playableGraph_144);
            args = new Type[]{};
            method = type.GetMethod("get_layersAffectMassCenter", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_layersAffectMassCenter_145);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_layersAffectMassCenter", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_layersAffectMassCenter_146);
            args = new Type[]{};
            method = type.GetMethod("get_leftFeetBottomHeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_leftFeetBottomHeight_147);
            args = new Type[]{};
            method = type.GetMethod("get_rightFeetBottomHeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_rightFeetBottomHeight_148);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("Update", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Update_149);
            args = new Type[]{};
            method = type.GetMethod("Rebind", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Rebind_150);
            args = new Type[]{};
            method = type.GetMethod("ApplyBuiltinRootMotion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ApplyBuiltinRootMotion_151);
            args = new Type[]{};
            method = type.GetMethod("get_logWarnings", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_logWarnings_152);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_logWarnings", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_logWarnings_153);
            args = new Type[]{};
            method = type.GetMethod("get_fireEvents", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_fireEvents_154);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_fireEvents", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_fireEvents_155);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Animator());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Animator[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_isOptimizable_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isOptimizable;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_isHuman_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isHuman;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_hasRootMotion_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hasRootMotion;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_humanScale_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.humanScale;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_isInitialized_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isInitialized;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetFloat_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetFloat(name);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetFloat_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 id = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetFloat(id);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetFloat_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetFloat(name, value);

            return __ret;
        }

        static StackObject* SetFloat_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single deltaTime = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single dampTime = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetFloat(name, value, dampTime, deltaTime);

            return __ret;
        }

        static StackObject* SetFloat_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 id = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetFloat(id, value);

            return __ret;
        }

        static StackObject* SetFloat_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single deltaTime = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single dampTime = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 id = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetFloat(id, value, dampTime, deltaTime);

            return __ret;
        }

        static StackObject* GetBool_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetBool(name);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetBool_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 id = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetBool(id);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SetBool_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetBool(name, value);

            return __ret;
        }

        static StackObject* SetBool_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 id = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetBool(id, value);

            return __ret;
        }

        static StackObject* GetInteger_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetInteger(name);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetInteger_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 id = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetInteger(id);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetInteger_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetInteger(name, value);

            return __ret;
        }

        static StackObject* SetInteger_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 id = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetInteger(id, value);

            return __ret;
        }

        static StackObject* SetTrigger_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetTrigger(name);

            return __ret;
        }

        static StackObject* SetTrigger_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 id = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetTrigger(id);

            return __ret;
        }

        static StackObject* ResetTrigger_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ResetTrigger(name);

            return __ret;
        }

        static StackObject* ResetTrigger_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 id = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ResetTrigger(id);

            return __ret;
        }

        static StackObject* IsParameterControlledByCurve_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsParameterControlledByCurve(name);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsParameterControlledByCurve_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 id = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsParameterControlledByCurve(id);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_deltaPosition_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.deltaPosition;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_deltaRotation_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.deltaRotation;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_velocity_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.velocity;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_angularVelocity_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.angularVelocity;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_rootPosition_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.rootPosition;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_rootPosition_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.rootPosition = value;

            return __ret;
        }

        static StackObject* get_rootRotation_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.rootRotation;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_rootRotation_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion value = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.rootRotation = value;

            return __ret;
        }

        static StackObject* get_applyRootMotion_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.applyRootMotion;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_applyRootMotion_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.applyRootMotion = value;

            return __ret;
        }

        static StackObject* get_linearVelocityBlending_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.linearVelocityBlending;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_linearVelocityBlending_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.linearVelocityBlending = value;

            return __ret;
        }

        static StackObject* get_updateMode_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.updateMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_updateMode_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AnimatorUpdateMode value = (UnityEngine.AnimatorUpdateMode)typeof(UnityEngine.AnimatorUpdateMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.updateMode = value;

            return __ret;
        }

        static StackObject* get_hasTransformHierarchy_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hasTransformHierarchy;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_gravityWeight_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.gravityWeight;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_bodyPosition_41(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.bodyPosition;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_bodyPosition_42(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.bodyPosition = value;

            return __ret;
        }

        static StackObject* get_bodyRotation_43(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.bodyRotation;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_bodyRotation_44(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion value = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.bodyRotation = value;

            return __ret;
        }

        static StackObject* GetIKPosition_45(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AvatarIKGoal goal = (UnityEngine.AvatarIKGoal)typeof(UnityEngine.AvatarIKGoal).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetIKPosition(goal);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetIKPosition_46(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 goalPosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AvatarIKGoal goal = (UnityEngine.AvatarIKGoal)typeof(UnityEngine.AvatarIKGoal).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetIKPosition(goal, goalPosition);

            return __ret;
        }

        static StackObject* GetIKRotation_47(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AvatarIKGoal goal = (UnityEngine.AvatarIKGoal)typeof(UnityEngine.AvatarIKGoal).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetIKRotation(goal);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetIKRotation_48(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion goalRotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AvatarIKGoal goal = (UnityEngine.AvatarIKGoal)typeof(UnityEngine.AvatarIKGoal).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetIKRotation(goal, goalRotation);

            return __ret;
        }

        static StackObject* GetIKPositionWeight_49(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AvatarIKGoal goal = (UnityEngine.AvatarIKGoal)typeof(UnityEngine.AvatarIKGoal).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetIKPositionWeight(goal);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetIKPositionWeight_50(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AvatarIKGoal goal = (UnityEngine.AvatarIKGoal)typeof(UnityEngine.AvatarIKGoal).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetIKPositionWeight(goal, value);

            return __ret;
        }

        static StackObject* GetIKRotationWeight_51(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AvatarIKGoal goal = (UnityEngine.AvatarIKGoal)typeof(UnityEngine.AvatarIKGoal).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetIKRotationWeight(goal);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetIKRotationWeight_52(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AvatarIKGoal goal = (UnityEngine.AvatarIKGoal)typeof(UnityEngine.AvatarIKGoal).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetIKRotationWeight(goal, value);

            return __ret;
        }

        static StackObject* GetIKHintPosition_53(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AvatarIKHint hint = (UnityEngine.AvatarIKHint)typeof(UnityEngine.AvatarIKHint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetIKHintPosition(hint);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetIKHintPosition_54(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 hintPosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AvatarIKHint hint = (UnityEngine.AvatarIKHint)typeof(UnityEngine.AvatarIKHint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetIKHintPosition(hint, hintPosition);

            return __ret;
        }

        static StackObject* GetIKHintPositionWeight_55(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AvatarIKHint hint = (UnityEngine.AvatarIKHint)typeof(UnityEngine.AvatarIKHint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetIKHintPositionWeight(hint);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetIKHintPositionWeight_56(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AvatarIKHint hint = (UnityEngine.AvatarIKHint)typeof(UnityEngine.AvatarIKHint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetIKHintPositionWeight(hint, value);

            return __ret;
        }

        static StackObject* SetLookAtPosition_57(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 lookAtPosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetLookAtPosition(lookAtPosition);

            return __ret;
        }

        static StackObject* SetLookAtWeight_58(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single eyesWeight = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single headWeight = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single bodyWeight = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single weight = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetLookAtWeight(weight, bodyWeight, headWeight, eyesWeight);

            return __ret;
        }

        static StackObject* SetLookAtWeight_59(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single headWeight = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single bodyWeight = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single weight = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetLookAtWeight(weight, bodyWeight, headWeight);

            return __ret;
        }

        static StackObject* SetLookAtWeight_60(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single bodyWeight = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single weight = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetLookAtWeight(weight, bodyWeight);

            return __ret;
        }

        static StackObject* SetLookAtWeight_61(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single weight = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetLookAtWeight(weight);

            return __ret;
        }

        static StackObject* SetLookAtWeight_62(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single clampWeight = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single eyesWeight = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single headWeight = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single bodyWeight = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single weight = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetLookAtWeight(weight, bodyWeight, headWeight, eyesWeight, clampWeight);

            return __ret;
        }

        static StackObject* SetBoneLocalRotation_63(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.HumanBodyBones humanBoneId = (UnityEngine.HumanBodyBones)typeof(UnityEngine.HumanBodyBones).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetBoneLocalRotation(humanBoneId, rotation);

            return __ret;
        }

        static StackObject* GetBehaviours_64(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 fullPathHash = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetBehaviours(fullPathHash, layerIndex);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_stabilizeFeet_65(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.stabilizeFeet;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_stabilizeFeet_66(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.stabilizeFeet = value;

            return __ret;
        }

        static StackObject* get_layerCount_67(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.layerCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetLayerName_68(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetLayerName(layerIndex);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetLayerIndex_69(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String layerName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetLayerIndex(layerName);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetLayerWeight_70(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetLayerWeight(layerIndex);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetLayerWeight_71(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single weight = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetLayerWeight(layerIndex, weight);

            return __ret;
        }

        static StackObject* GetCurrentAnimatorStateInfo_72(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetCurrentAnimatorStateInfo(layerIndex);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetNextAnimatorStateInfo_73(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetNextAnimatorStateInfo(layerIndex);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetAnimatorTransitionInfo_74(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetAnimatorTransitionInfo(layerIndex);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetCurrentAnimatorClipInfoCount_75(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetCurrentAnimatorClipInfoCount(layerIndex);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetCurrentAnimatorClipInfo_76(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetCurrentAnimatorClipInfo(layerIndex);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetCurrentAnimatorClipInfo_77(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips = (System.Collections.Generic.List<UnityEngine.AnimatorClipInfo>)typeof(System.Collections.Generic.List<UnityEngine.AnimatorClipInfo>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetCurrentAnimatorClipInfo(layerIndex, clips);

            return __ret;
        }

        static StackObject* GetNextAnimatorClipInfoCount_78(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetNextAnimatorClipInfoCount(layerIndex);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetNextAnimatorClipInfo_79(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetNextAnimatorClipInfo(layerIndex);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetNextAnimatorClipInfo_80(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips = (System.Collections.Generic.List<UnityEngine.AnimatorClipInfo>)typeof(System.Collections.Generic.List<UnityEngine.AnimatorClipInfo>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetNextAnimatorClipInfo(layerIndex, clips);

            return __ret;
        }

        static StackObject* IsInTransition_81(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsInTransition(layerIndex);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_parameters_82(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.parameters;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_parameterCount_83(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.parameterCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetParameter_84(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetParameter(index);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_feetPivotActive_85(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.feetPivotActive;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_feetPivotActive_86(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.feetPivotActive = value;

            return __ret;
        }

        static StackObject* get_pivotWeight_87(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.pivotWeight;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_pivotPosition_88(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.pivotPosition;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* MatchTarget_89(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single targetNormalizedTime = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single startNormalizedTime = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.MatchTargetWeightMask weightMask = (UnityEngine.MatchTargetWeightMask)typeof(UnityEngine.MatchTargetWeightMask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.AvatarTarget targetBodyPart = (UnityEngine.AvatarTarget)typeof(UnityEngine.AvatarTarget).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Quaternion matchRotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector3 matchPosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MatchTarget(matchPosition, matchRotation, targetBodyPart, weightMask, startNormalizedTime, targetNormalizedTime);

            return __ret;
        }

        static StackObject* MatchTarget_90(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single startNormalizedTime = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.MatchTargetWeightMask weightMask = (UnityEngine.MatchTargetWeightMask)typeof(UnityEngine.MatchTargetWeightMask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.AvatarTarget targetBodyPart = (UnityEngine.AvatarTarget)typeof(UnityEngine.AvatarTarget).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Quaternion matchRotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector3 matchPosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MatchTarget(matchPosition, matchRotation, targetBodyPart, weightMask, startNormalizedTime);

            return __ret;
        }

        static StackObject* InterruptMatchTarget_91(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean completeMatch = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.InterruptMatchTarget(completeMatch);

            return __ret;
        }

        static StackObject* InterruptMatchTarget_92(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.InterruptMatchTarget();

            return __ret;
        }

        static StackObject* get_isMatchingTarget_93(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isMatchingTarget;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_speed_94(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.speed;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_speed_95(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.speed = value;

            return __ret;
        }

        static StackObject* CrossFadeInFixedTime_96(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single transitionDuration = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String stateName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CrossFadeInFixedTime(stateName, transitionDuration, layer);

            return __ret;
        }

        static StackObject* CrossFadeInFixedTime_97(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single transitionDuration = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String stateName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CrossFadeInFixedTime(stateName, transitionDuration);

            return __ret;
        }

        static StackObject* CrossFadeInFixedTime_98(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single fixedTime = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single transitionDuration = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String stateName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CrossFadeInFixedTime(stateName, transitionDuration, layer, fixedTime);

            return __ret;
        }

        static StackObject* CrossFadeInFixedTime_99(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single fixedTime = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single transitionDuration = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 stateNameHash = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CrossFadeInFixedTime(stateNameHash, transitionDuration, layer, fixedTime);

            return __ret;
        }

        static StackObject* CrossFadeInFixedTime_100(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single transitionDuration = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 stateNameHash = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CrossFadeInFixedTime(stateNameHash, transitionDuration, layer);

            return __ret;
        }

        static StackObject* CrossFadeInFixedTime_101(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single transitionDuration = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 stateNameHash = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CrossFadeInFixedTime(stateNameHash, transitionDuration);

            return __ret;
        }

        static StackObject* CrossFade_102(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single transitionDuration = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String stateName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CrossFade(stateName, transitionDuration, layer);

            return __ret;
        }

        static StackObject* CrossFade_103(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single transitionDuration = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String stateName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CrossFade(stateName, transitionDuration);

            return __ret;
        }

        static StackObject* CrossFade_104(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single normalizedTime = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single transitionDuration = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String stateName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CrossFade(stateName, transitionDuration, layer, normalizedTime);

            return __ret;
        }

        static StackObject* CrossFade_105(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single normalizedTime = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single transitionDuration = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 stateNameHash = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CrossFade(stateNameHash, transitionDuration, layer, normalizedTime);

            return __ret;
        }

        static StackObject* CrossFade_106(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single transitionDuration = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 stateNameHash = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CrossFade(stateNameHash, transitionDuration, layer);

            return __ret;
        }

        static StackObject* CrossFade_107(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single transitionDuration = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 stateNameHash = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CrossFade(stateNameHash, transitionDuration);

            return __ret;
        }

        static StackObject* PlayInFixedTime_108(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String stateName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.PlayInFixedTime(stateName, layer);

            return __ret;
        }

        static StackObject* PlayInFixedTime_109(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String stateName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.PlayInFixedTime(stateName);

            return __ret;
        }

        static StackObject* PlayInFixedTime_110(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single fixedTime = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String stateName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.PlayInFixedTime(stateName, layer, fixedTime);

            return __ret;
        }

        static StackObject* PlayInFixedTime_111(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single fixedTime = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 stateNameHash = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.PlayInFixedTime(stateNameHash, layer, fixedTime);

            return __ret;
        }

        static StackObject* PlayInFixedTime_112(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 stateNameHash = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.PlayInFixedTime(stateNameHash, layer);

            return __ret;
        }

        static StackObject* PlayInFixedTime_113(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 stateNameHash = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.PlayInFixedTime(stateNameHash);

            return __ret;
        }

        static StackObject* Play_114(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String stateName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Play(stateName, layer);

            return __ret;
        }

        static StackObject* Play_115(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String stateName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Play(stateName);

            return __ret;
        }

        static StackObject* Play_116(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single normalizedTime = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String stateName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Play(stateName, layer, normalizedTime);

            return __ret;
        }

        static StackObject* Play_117(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single normalizedTime = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 stateNameHash = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Play(stateNameHash, layer, normalizedTime);

            return __ret;
        }

        static StackObject* Play_118(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 stateNameHash = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Play(stateNameHash, layer);

            return __ret;
        }

        static StackObject* Play_119(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 stateNameHash = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Play(stateNameHash);

            return __ret;
        }

        static StackObject* SetTarget_120(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single targetNormalizedTime = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AvatarTarget targetIndex = (UnityEngine.AvatarTarget)typeof(UnityEngine.AvatarTarget).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetTarget(targetIndex, targetNormalizedTime);

            return __ret;
        }

        static StackObject* get_targetPosition_121(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.targetPosition;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_targetRotation_122(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.targetRotation;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetBoneTransform_123(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.HumanBodyBones humanBoneId = (UnityEngine.HumanBodyBones)typeof(UnityEngine.HumanBodyBones).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetBoneTransform(humanBoneId);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_cullingMode_124(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.cullingMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_cullingMode_125(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AnimatorCullingMode value = (UnityEngine.AnimatorCullingMode)typeof(UnityEngine.AnimatorCullingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.cullingMode = value;

            return __ret;
        }

        static StackObject* StartPlayback_126(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.StartPlayback();

            return __ret;
        }

        static StackObject* StopPlayback_127(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.StopPlayback();

            return __ret;
        }

        static StackObject* get_playbackTime_128(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.playbackTime;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_playbackTime_129(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.playbackTime = value;

            return __ret;
        }

        static StackObject* StartRecording_130(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 frameCount = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.StartRecording(frameCount);

            return __ret;
        }

        static StackObject* StopRecording_131(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.StopRecording();

            return __ret;
        }

        static StackObject* get_recorderStartTime_132(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.recorderStartTime;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_recorderStartTime_133(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.recorderStartTime = value;

            return __ret;
        }

        static StackObject* get_recorderStopTime_134(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.recorderStopTime;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_recorderStopTime_135(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.recorderStopTime = value;

            return __ret;
        }

        static StackObject* get_recorderMode_136(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.recorderMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_runtimeAnimatorController_137(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.runtimeAnimatorController;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_runtimeAnimatorController_138(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RuntimeAnimatorController value = (UnityEngine.RuntimeAnimatorController)typeof(UnityEngine.RuntimeAnimatorController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.runtimeAnimatorController = value;

            return __ret;
        }

        static StackObject* get_hasBoundPlayables_139(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hasBoundPlayables;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* HasState_140(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 stateID = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.HasState(layerIndex, stateID);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* StringToHash_141(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.Animator.StringToHash(name);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_avatar_142(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.avatar;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_avatar_143(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Avatar value = (UnityEngine.Avatar)typeof(UnityEngine.Avatar).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.avatar = value;

            return __ret;
        }

        static StackObject* get_playableGraph_144(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.playableGraph;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_layersAffectMassCenter_145(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.layersAffectMassCenter;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_layersAffectMassCenter_146(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.layersAffectMassCenter = value;

            return __ret;
        }

        static StackObject* get_leftFeetBottomHeight_147(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.leftFeetBottomHeight;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_rightFeetBottomHeight_148(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.rightFeetBottomHeight;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Update_149(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single deltaTime = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Update(deltaTime);

            return __ret;
        }

        static StackObject* Rebind_150(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Rebind();

            return __ret;
        }

        static StackObject* ApplyBuiltinRootMotion_151(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ApplyBuiltinRootMotion();

            return __ret;
        }

        static StackObject* get_logWarnings_152(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.logWarnings;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_logWarnings_153(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.logWarnings = value;

            return __ret;
        }

        static StackObject* get_fireEvents_154(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.fireEvents;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_fireEvents_155(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator instance_of_this_method;
            instance_of_this_method = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.fireEvents = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Animator();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
