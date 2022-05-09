#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>



// DevLocker.Utils.SceneReference
struct SceneReference_t71A8C510E8C95A21AA956AE7F33EE25B10770B60;
// System.String
struct String_t;

IL2CPP_EXTERN_C RuntimeClass* Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* SceneReference_t71A8C510E8C95A21AA956AE7F33EE25B10770B60_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* String_t_il2cpp_TypeInfo_var;


IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// <Module>
struct U3CModuleU3E_tF062866229C4952B8051AD32AB6E9D931142CC95 
{
};
struct Il2CppArrayBounds;

// DevLocker.Utils.SceneReference
struct SceneReference_t71A8C510E8C95A21AA956AE7F33EE25B10770B60  : public RuntimeObject
{
	// System.String DevLocker.Utils.SceneReference::m_ScenePath
	String_t* ___m_ScenePath_0;
};

// System.String
struct String_t  : public RuntimeObject
{
	// System.Int32 System.String::_stringLength
	int32_t ____stringLength_4;
	// System.Char System.String::_firstChar
	Il2CppChar ____firstChar_5;
};

struct String_t_StaticFields
{
	// System.String System.String::Empty
	String_t* ___Empty_6;
};

// System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F  : public RuntimeObject
{
};
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_com
{
};

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22 
{
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;
};

struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_StaticFields
{
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;
};

// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915 
{
	union
	{
		struct
		{
		};
		uint8_t Void_t4861ACF8F4594C3437BB48B6E56783494B843915__padding[1];
	};
};
#ifdef __clang__
#pragma clang diagnostic pop
#endif



// System.String DevLocker.Utils.SceneReference::get_ScenePath()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* SceneReference_get_ScenePath_m11519D445BFDA1E3BC7769C1E8EB8B4EEA696843_inline (SceneReference_t71A8C510E8C95A21AA956AE7F33EE25B10770B60* __this, const RuntimeMethod* method) ;
// System.String System.IO.Path::GetFileNameWithoutExtension(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Path_GetFileNameWithoutExtension_mD24A7CA7C45FF7A265EF7F8D5E19D1F3C014D90F (String_t* ___path0, const RuntimeMethod* method) ;
// System.Boolean System.String::IsNullOrEmpty(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_IsNullOrEmpty_m54CF0907E7C4F3AFB2E796A13DC751ECBB8DB64A (String_t* ___value0, const RuntimeMethod* method) ;
// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2 (RuntimeObject* __this, const RuntimeMethod* method) ;
// System.Void DevLocker.Utils.SceneReference::set_ScenePath(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void SceneReference_set_ScenePath_mCC75A57D15138F3ACF661A8EC305B9DFDA27A806_inline (SceneReference_t71A8C510E8C95A21AA956AE7F33EE25B10770B60* __this, String_t* ___value0, const RuntimeMethod* method) ;
// System.Void DevLocker.Utils.SceneReference::.ctor(DevLocker.Utils.SceneReference)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SceneReference__ctor_m313E36F3F92ED71512ABCABBA6047F7DF6E55766 (SceneReference_t71A8C510E8C95A21AA956AE7F33EE25B10770B60* __this, SceneReference_t71A8C510E8C95A21AA956AE7F33EE25B10770B60* ___other0, const RuntimeMethod* method) ;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.String DevLocker.Utils.SceneReference::get_ScenePath()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* SceneReference_get_ScenePath_m11519D445BFDA1E3BC7769C1E8EB8B4EEA696843 (SceneReference_t71A8C510E8C95A21AA956AE7F33EE25B10770B60* __this, const RuntimeMethod* method) 
{
	{
		// return m_ScenePath;
		String_t* L_0 = __this->___m_ScenePath_0;
		return L_0;
	}
}
// System.Void DevLocker.Utils.SceneReference::set_ScenePath(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SceneReference_set_ScenePath_mCC75A57D15138F3ACF661A8EC305B9DFDA27A806 (SceneReference_t71A8C510E8C95A21AA956AE7F33EE25B10770B60* __this, String_t* ___value0, const RuntimeMethod* method) 
{
	{
		// m_ScenePath = value;
		String_t* L_0 = ___value0;
		__this->___m_ScenePath_0 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_ScenePath_0), (void*)L_0);
		// }
		return;
	}
}
// System.String DevLocker.Utils.SceneReference::get_SceneName()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* SceneReference_get_SceneName_m951FB1FEF67CD2CBCD107139F068785368139A87 (SceneReference_t71A8C510E8C95A21AA956AE7F33EE25B10770B60* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// public string SceneName => Path.GetFileNameWithoutExtension(ScenePath);
		String_t* L_0;
		L_0 = SceneReference_get_ScenePath_m11519D445BFDA1E3BC7769C1E8EB8B4EEA696843_inline(__this, NULL);
		il2cpp_codegen_runtime_class_init_inline(Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
		String_t* L_1;
		L_1 = Path_GetFileNameWithoutExtension_mD24A7CA7C45FF7A265EF7F8D5E19D1F3C014D90F(L_0, NULL);
		return L_1;
	}
}
// System.Boolean DevLocker.Utils.SceneReference::get_IsEmpty()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool SceneReference_get_IsEmpty_m016764A03F120B0DD61D9D6B7BBE4614FB466815 (SceneReference_t71A8C510E8C95A21AA956AE7F33EE25B10770B60* __this, const RuntimeMethod* method) 
{
	{
		// public bool IsEmpty => string.IsNullOrEmpty(ScenePath);
		String_t* L_0;
		L_0 = SceneReference_get_ScenePath_m11519D445BFDA1E3BC7769C1E8EB8B4EEA696843_inline(__this, NULL);
		bool L_1;
		L_1 = String_IsNullOrEmpty_m54CF0907E7C4F3AFB2E796A13DC751ECBB8DB64A(L_0, NULL);
		return L_1;
	}
}
// System.Void DevLocker.Utils.SceneReference::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SceneReference__ctor_m16CA4AF8A9D59E2B5F2F932D00B72ACE1EE713C0 (SceneReference_t71A8C510E8C95A21AA956AE7F33EE25B10770B60* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// private string m_ScenePath = string.Empty;
		String_t* L_0 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->___Empty_6;
		__this->___m_ScenePath_0 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_ScenePath_0), (void*)L_0);
		// public SceneReference() { }
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		// public SceneReference() { }
		return;
	}
}
// System.Void DevLocker.Utils.SceneReference::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SceneReference__ctor_m21C8CA58AA8336CB179543D27605E19293464CD0 (SceneReference_t71A8C510E8C95A21AA956AE7F33EE25B10770B60* __this, String_t* ___scenePath0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// private string m_ScenePath = string.Empty;
		String_t* L_0 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->___Empty_6;
		__this->___m_ScenePath_0 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_ScenePath_0), (void*)L_0);
		// public SceneReference(string scenePath)
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		// ScenePath = scenePath;
		String_t* L_1 = ___scenePath0;
		SceneReference_set_ScenePath_mCC75A57D15138F3ACF661A8EC305B9DFDA27A806_inline(__this, L_1, NULL);
		// }
		return;
	}
}
// System.Void DevLocker.Utils.SceneReference::.ctor(DevLocker.Utils.SceneReference)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SceneReference__ctor_m313E36F3F92ED71512ABCABBA6047F7DF6E55766 (SceneReference_t71A8C510E8C95A21AA956AE7F33EE25B10770B60* __this, SceneReference_t71A8C510E8C95A21AA956AE7F33EE25B10770B60* ___other0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// private string m_ScenePath = string.Empty;
		String_t* L_0 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->___Empty_6;
		__this->___m_ScenePath_0 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_ScenePath_0), (void*)L_0);
		// public SceneReference(SceneReference other)
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		// m_ScenePath = other.m_ScenePath;
		SceneReference_t71A8C510E8C95A21AA956AE7F33EE25B10770B60* L_1 = ___other0;
		NullCheck(L_1);
		String_t* L_2 = L_1->___m_ScenePath_0;
		__this->___m_ScenePath_0 = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_ScenePath_0), (void*)L_2);
		// }
		return;
	}
}
// DevLocker.Utils.SceneReference DevLocker.Utils.SceneReference::Clone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR SceneReference_t71A8C510E8C95A21AA956AE7F33EE25B10770B60* SceneReference_Clone_m475C41D86BF645796B640D01BBEF3ED9989406E7 (SceneReference_t71A8C510E8C95A21AA956AE7F33EE25B10770B60* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SceneReference_t71A8C510E8C95A21AA956AE7F33EE25B10770B60_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// public SceneReference Clone() => new SceneReference(this);
		SceneReference_t71A8C510E8C95A21AA956AE7F33EE25B10770B60* L_0 = (SceneReference_t71A8C510E8C95A21AA956AE7F33EE25B10770B60*)il2cpp_codegen_object_new(SceneReference_t71A8C510E8C95A21AA956AE7F33EE25B10770B60_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		SceneReference__ctor_m313E36F3F92ED71512ABCABBA6047F7DF6E55766(L_0, __this, NULL);
		return L_0;
	}
}
// System.String DevLocker.Utils.SceneReference::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* SceneReference_ToString_m871E0CE492306EA0580938E4E47FD4F0154FB5D7 (SceneReference_t71A8C510E8C95A21AA956AE7F33EE25B10770B60* __this, const RuntimeMethod* method) 
{
	{
		// return m_ScenePath;
		String_t* L_0 = __this->___m_ScenePath_0;
		return L_0;
	}
}
// System.Void DevLocker.Utils.SceneReference::OnBeforeSerialize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SceneReference_OnBeforeSerialize_m52961071A25DA0CCDFC2C176FB0BD150F645CAF3 (SceneReference_t71A8C510E8C95A21AA956AE7F33EE25B10770B60* __this, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DevLocker.Utils.SceneReference::OnAfterDeserialize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SceneReference_OnAfterDeserialize_mE66345D26D6DBC5669651CCEB6A70EEACF83EDC2 (SceneReference_t71A8C510E8C95A21AA956AE7F33EE25B10770B60* __this, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* SceneReference_get_ScenePath_m11519D445BFDA1E3BC7769C1E8EB8B4EEA696843_inline (SceneReference_t71A8C510E8C95A21AA956AE7F33EE25B10770B60* __this, const RuntimeMethod* method) 
{
	{
		// return m_ScenePath;
		String_t* L_0 = __this->___m_ScenePath_0;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void SceneReference_set_ScenePath_mCC75A57D15138F3ACF661A8EC305B9DFDA27A806_inline (SceneReference_t71A8C510E8C95A21AA956AE7F33EE25B10770B60* __this, String_t* ___value0, const RuntimeMethod* method) 
{
	{
		// m_ScenePath = value;
		String_t* L_0 = ___value0;
		__this->___m_ScenePath_0 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_ScenePath_0), (void*)L_0);
		// }
		return;
	}
}
