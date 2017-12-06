﻿using System;
using System.Collections.Generic;
using System.Reflection;

namespace ILRuntime.Runtime.Generated
{
    class CLRBindings
    {
        /// <summary>
        /// Initialize the CLR binding, please invoke this AFTER CLR Redirection registration
        /// </summary>
        public static void Initialize(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            App_Binding.Register(app);
            AssetbundleLoader_Binding.Register(app);
            Google_Protobuf_ByteString_Binding.Register(app);
            Google_Protobuf_CodedInputStream_Binding.Register(app);
            Google_Protobuf_CodedOutputStream_Binding.Register(app);
            Google_Protobuf_Collections_RepeatedField_1_Adaptor_Binding.Register(app);
            Google_Protobuf_Collections_RepeatedField_1_Int32_Binding.Register(app);
            Google_Protobuf_MessageExtensions_Binding.Register(app);
            Google_Protobuf_MessageParser_1_Adaptor_Binding.Register(app);
            Google_Protobuf_ProtoPreconditions_Binding.Register(app);
            PressEventTrigger_Binding.Register(app);
            System_Action_Binding.Register(app);
            System_Array_Binding.Register(app);
            System_BitConverter_Binding.Register(app);
            System_Boolean_Binding.Register(app);
            System_Buffer_Binding.Register(app);
            System_Byte_Binding.Register(app);
            System_Char_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_ILTypeInstance_Binding_ValueCollection_Int32_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_ILTypeInstance_Binding_ValueCollection_Int32_ILTypeInstance_Binding_Enumerator_Int32_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_Int32_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_List_1_GameObject_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_ILTypeInstance_Binding_Enumerator_String_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_KeyValuePair_2_String_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_LinkedListNode_1_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_LinkedList_1_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_List_1_Adaptor_Binding.Register(app);
            System_Collections_Generic_List_1_Byte_Array_Binding.Register(app);
            System_Collections_Generic_List_1_Byte_Binding.Register(app);
            System_Collections_Generic_List_1_GameObject_Binding.Register(app);
            System_Collections_Generic_List_1_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_List_1_Int32_Array_Binding.Register(app);
            System_Collections_Generic_List_1_Int32_Binding.Register(app);
            System_Collections_Generic_List_1_List_1_Vector3_Binding.Register(app);
            System_Collections_Generic_List_1_Single_Array_Binding.Register(app);
            System_Collections_Generic_List_1_Sprite_Binding.Register(app);
            System_Collections_Generic_List_1_String_Binding.Register(app);
            System_Collections_Generic_List_1_Vector3_Binding.Register(app);
            System_Collections_Generic_Queue_1_Adaptor_Binding.Register(app);
            System_Collections_Generic_Queue_1_GameObject_Binding.Register(app);
            System_Collections_Generic_Queue_1_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Queue_1_ILTypeInstance_Binding_Enumerator_ILTypeInstance_Binding.Register(app);
            System_Collections_Queue_Binding.Register(app);
            System_ComponentModel_Win32Exception_Binding.Register(app);
            System_Convert_Binding.Register(app);
            System_DateTime_Binding.Register(app);
            System_Diagnostics_Debug_Binding.Register(app);
            System_IDisposable_Binding.Register(app);
            System_Int32_Binding.Register(app);
            System_Int64_Binding.Register(app);
            System_IO_MemoryStream_Binding.Register(app);
            System_IO_Stream_Binding.Register(app);
            System_Math_Binding.Register(app);
            System_Net_Dns_Binding.Register(app);
            System_Net_IPAddress_Binding.Register(app);
            System_Net_IPEndPoint_Binding.Register(app);
            System_Net_Sockets_Socket_Binding.Register(app);
            System_Object_Binding.Register(app);
            System_Single_Binding.Register(app);
            System_String_Binding.Register(app);
            System_Threading_Interlocked_Binding.Register(app);
            System_Threading_Monitor_Binding.Register(app);
            System_Threading_Thread_Binding.Register(app);
            System_TimeSpan_Binding.Register(app);
            System_UInt32_Binding.Register(app);
#if UNITY_ANDROID
            UnityEngine_AndroidJavaClass_Binding.Register(app);
#endif
#if UNITY_ANDROID
            UnityEngine_AndroidJavaObject_Binding.Register(app);
#endif
            UnityEngine_Animator_Binding.Register(app);
            UnityEngine_Application_Binding.Register(app);
            UnityEngine_AudioSource_Binding.Register(app);
            UnityEngine_Behaviour_Binding.Register(app);
            UnityEngine_BoxCollider2D_Binding.Register(app);
            UnityEngine_Camera_Binding.Register(app);
            UnityEngine_Canvas_Binding.Register(app);
            UnityEngine_Component_Binding.Register(app);
            UnityEngine_Debug_Binding.Register(app);
            UnityEngine_Events_UnityEventBase_Binding.Register(app);
            UnityEngine_Events_UnityEvent_Binding.Register(app);
            UnityEngine_GameObject_Binding.Register(app);
            UnityEngine_HingeJoint2D_Binding.Register(app);
            UnityEngine_ImageConversion_Binding.Register(app);
            UnityEngine_Input_Binding.Register(app);
            UnityEngine_JointAngleLimits2D_Binding.Register(app);
            UnityEngine_JointMotor2D_Binding.Register(app);
            UnityEngine_Material_Binding.Register(app);
            UnityEngine_Mathf_Binding.Register(app);
            UnityEngine_Object_Binding.Register(app);
            UnityEngine_ParticleSystem_Binding.Register(app);
            UnityEngine_Quaternion_Binding.Register(app);
            UnityEngine_Random_Binding.Register(app);
            UnityEngine_RectTransform_Binding.Register(app);
            UnityEngine_Rect_Binding.Register(app);
            UnityEngine_Renderer_Binding.Register(app);
            UnityEngine_Rigidbody2D_Binding.Register(app);
            UnityEngine_Screen_Binding.Register(app);
            UnityEngine_SpriteRenderer_Binding.Register(app);
            UnityEngine_Sprite_Binding.Register(app);
            UnityEngine_Texture2D_Binding.Register(app);
            UnityEngine_Texture_Binding.Register(app);
            UnityEngine_Time_Binding.Register(app);
            UnityEngine_Touch_Binding.Register(app);
            UnityEngine_Transform_Binding.Register(app);
            UnityEngine_UI_Button_Binding.Register(app);
            UnityEngine_UI_Graphic_Binding.Register(app);
            UnityEngine_UI_Image_Binding.Register(app);
            UnityEngine_UI_Text_Binding.Register(app);
            UnityEngine_Vector2_Binding.Register(app);
            UnityEngine_Vector3_Binding.Register(app);

        }
    }
}
