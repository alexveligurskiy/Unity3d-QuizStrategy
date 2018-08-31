#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <cstring>
#include <string.h>
#include <stdio.h>
#include <cmath>
#include <limits>
#include <assert.h>
#include <stdint.h>

#include "il2cpp-class-internals.h"
#include "codegen/il2cpp-codegen.h"
#include "il2cpp-object-internals.h"


// SimpleObjectPool
struct SimpleObjectPool_t1028341060;
// System.Collections.Generic.List`1<Building>
struct List_1_t2883330737;
// System.Collections.Generic.Stack`1<UnityEngine.GameObject>
struct Stack_1_t1957026074;
// System.String
struct String_t;
// System.Void
struct Void_t1185182177;
// UnityEngine.GameObject
struct GameObject_t1113636619;
// UnityEngine.Sprite
struct Sprite_t280657092;
// UnityEngine.Transform
struct Transform_t3600365921;
// UnityEngine.UI.Text
struct Text_t1901882714;




#ifndef RUNTIMEOBJECT_H
#define RUNTIMEOBJECT_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Object

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // RUNTIMEOBJECT_H
#ifndef BUILDING_T1411255995_H
#define BUILDING_T1411255995_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Building
struct  Building_t1411255995  : public RuntimeObject
{
public:
	// System.String Building::name
	String_t* ___name_0;
	// System.Single Building::price
	float ___price_1;
	// UnityEngine.Sprite Building::icon
	Sprite_t280657092 * ___icon_2;
	// System.Single Building::earnings
	float ___earnings_3;
	// System.Boolean Building::isBuild
	bool ___isBuild_4;
	// System.Boolean Building::isDestroyed
	bool ___isDestroyed_5;
	// System.Int32 Building::kindOfBuilding
	int32_t ___kindOfBuilding_6;
	// System.Int32 Building::armyForce
	int32_t ___armyForce_7;
	// System.Int32 Building::armyForcePerStep
	int32_t ___armyForcePerStep_8;
	// System.Int32 Building::ecologyCont
	int32_t ___ecologyCont_9;
	// System.Int32 Building::peopleCont
	int32_t ___peopleCont_10;
	// System.Int32 Building::armyCont
	int32_t ___armyCont_11;
	// System.Int32 Building::scienceCont
	int32_t ___scienceCont_12;

public:
	inline static int32_t get_offset_of_name_0() { return static_cast<int32_t>(offsetof(Building_t1411255995, ___name_0)); }
	inline String_t* get_name_0() const { return ___name_0; }
	inline String_t** get_address_of_name_0() { return &___name_0; }
	inline void set_name_0(String_t* value)
	{
		___name_0 = value;
		Il2CppCodeGenWriteBarrier((&___name_0), value);
	}

	inline static int32_t get_offset_of_price_1() { return static_cast<int32_t>(offsetof(Building_t1411255995, ___price_1)); }
	inline float get_price_1() const { return ___price_1; }
	inline float* get_address_of_price_1() { return &___price_1; }
	inline void set_price_1(float value)
	{
		___price_1 = value;
	}

	inline static int32_t get_offset_of_icon_2() { return static_cast<int32_t>(offsetof(Building_t1411255995, ___icon_2)); }
	inline Sprite_t280657092 * get_icon_2() const { return ___icon_2; }
	inline Sprite_t280657092 ** get_address_of_icon_2() { return &___icon_2; }
	inline void set_icon_2(Sprite_t280657092 * value)
	{
		___icon_2 = value;
		Il2CppCodeGenWriteBarrier((&___icon_2), value);
	}

	inline static int32_t get_offset_of_earnings_3() { return static_cast<int32_t>(offsetof(Building_t1411255995, ___earnings_3)); }
	inline float get_earnings_3() const { return ___earnings_3; }
	inline float* get_address_of_earnings_3() { return &___earnings_3; }
	inline void set_earnings_3(float value)
	{
		___earnings_3 = value;
	}

	inline static int32_t get_offset_of_isBuild_4() { return static_cast<int32_t>(offsetof(Building_t1411255995, ___isBuild_4)); }
	inline bool get_isBuild_4() const { return ___isBuild_4; }
	inline bool* get_address_of_isBuild_4() { return &___isBuild_4; }
	inline void set_isBuild_4(bool value)
	{
		___isBuild_4 = value;
	}

	inline static int32_t get_offset_of_isDestroyed_5() { return static_cast<int32_t>(offsetof(Building_t1411255995, ___isDestroyed_5)); }
	inline bool get_isDestroyed_5() const { return ___isDestroyed_5; }
	inline bool* get_address_of_isDestroyed_5() { return &___isDestroyed_5; }
	inline void set_isDestroyed_5(bool value)
	{
		___isDestroyed_5 = value;
	}

	inline static int32_t get_offset_of_kindOfBuilding_6() { return static_cast<int32_t>(offsetof(Building_t1411255995, ___kindOfBuilding_6)); }
	inline int32_t get_kindOfBuilding_6() const { return ___kindOfBuilding_6; }
	inline int32_t* get_address_of_kindOfBuilding_6() { return &___kindOfBuilding_6; }
	inline void set_kindOfBuilding_6(int32_t value)
	{
		___kindOfBuilding_6 = value;
	}

	inline static int32_t get_offset_of_armyForce_7() { return static_cast<int32_t>(offsetof(Building_t1411255995, ___armyForce_7)); }
	inline int32_t get_armyForce_7() const { return ___armyForce_7; }
	inline int32_t* get_address_of_armyForce_7() { return &___armyForce_7; }
	inline void set_armyForce_7(int32_t value)
	{
		___armyForce_7 = value;
	}

	inline static int32_t get_offset_of_armyForcePerStep_8() { return static_cast<int32_t>(offsetof(Building_t1411255995, ___armyForcePerStep_8)); }
	inline int32_t get_armyForcePerStep_8() const { return ___armyForcePerStep_8; }
	inline int32_t* get_address_of_armyForcePerStep_8() { return &___armyForcePerStep_8; }
	inline void set_armyForcePerStep_8(int32_t value)
	{
		___armyForcePerStep_8 = value;
	}

	inline static int32_t get_offset_of_ecologyCont_9() { return static_cast<int32_t>(offsetof(Building_t1411255995, ___ecologyCont_9)); }
	inline int32_t get_ecologyCont_9() const { return ___ecologyCont_9; }
	inline int32_t* get_address_of_ecologyCont_9() { return &___ecologyCont_9; }
	inline void set_ecologyCont_9(int32_t value)
	{
		___ecologyCont_9 = value;
	}

	inline static int32_t get_offset_of_peopleCont_10() { return static_cast<int32_t>(offsetof(Building_t1411255995, ___peopleCont_10)); }
	inline int32_t get_peopleCont_10() const { return ___peopleCont_10; }
	inline int32_t* get_address_of_peopleCont_10() { return &___peopleCont_10; }
	inline void set_peopleCont_10(int32_t value)
	{
		___peopleCont_10 = value;
	}

	inline static int32_t get_offset_of_armyCont_11() { return static_cast<int32_t>(offsetof(Building_t1411255995, ___armyCont_11)); }
	inline int32_t get_armyCont_11() const { return ___armyCont_11; }
	inline int32_t* get_address_of_armyCont_11() { return &___armyCont_11; }
	inline void set_armyCont_11(int32_t value)
	{
		___armyCont_11 = value;
	}

	inline static int32_t get_offset_of_scienceCont_12() { return static_cast<int32_t>(offsetof(Building_t1411255995, ___scienceCont_12)); }
	inline int32_t get_scienceCont_12() const { return ___scienceCont_12; }
	inline int32_t* get_address_of_scienceCont_12() { return &___scienceCont_12; }
	inline void set_scienceCont_12(int32_t value)
	{
		___scienceCont_12 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // BUILDING_T1411255995_H
#ifndef VALUETYPE_T3640485471_H
#define VALUETYPE_T3640485471_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.ValueType
struct  ValueType_t3640485471  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t3640485471_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t3640485471_marshaled_com
{
};
#endif // VALUETYPE_T3640485471_H
#ifndef INTPTR_T_H
#define INTPTR_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.IntPtr
struct  IntPtr_t 
{
public:
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(IntPtr_t, ___m_value_0)); }
	inline void* get_m_value_0() const { return ___m_value_0; }
	inline void** get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(void* value)
	{
		___m_value_0 = value;
	}
};

struct IntPtr_t_StaticFields
{
public:
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;

public:
	inline static int32_t get_offset_of_Zero_1() { return static_cast<int32_t>(offsetof(IntPtr_t_StaticFields, ___Zero_1)); }
	inline intptr_t get_Zero_1() const { return ___Zero_1; }
	inline intptr_t* get_address_of_Zero_1() { return &___Zero_1; }
	inline void set_Zero_1(intptr_t value)
	{
		___Zero_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // INTPTR_T_H
#ifndef OBJECT_T631007953_H
#define OBJECT_T631007953_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Object
struct  Object_t631007953  : public RuntimeObject
{
public:
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	intptr_t ___m_CachedPtr_0;

public:
	inline static int32_t get_offset_of_m_CachedPtr_0() { return static_cast<int32_t>(offsetof(Object_t631007953, ___m_CachedPtr_0)); }
	inline intptr_t get_m_CachedPtr_0() const { return ___m_CachedPtr_0; }
	inline intptr_t* get_address_of_m_CachedPtr_0() { return &___m_CachedPtr_0; }
	inline void set_m_CachedPtr_0(intptr_t value)
	{
		___m_CachedPtr_0 = value;
	}
};

struct Object_t631007953_StaticFields
{
public:
	// System.Int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
	int32_t ___OffsetOfInstanceIDInCPlusPlusObject_1;

public:
	inline static int32_t get_offset_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return static_cast<int32_t>(offsetof(Object_t631007953_StaticFields, ___OffsetOfInstanceIDInCPlusPlusObject_1)); }
	inline int32_t get_OffsetOfInstanceIDInCPlusPlusObject_1() const { return ___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline int32_t* get_address_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return &___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline void set_OffsetOfInstanceIDInCPlusPlusObject_1(int32_t value)
	{
		___OffsetOfInstanceIDInCPlusPlusObject_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_t631007953_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_t631007953_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};
#endif // OBJECT_T631007953_H
#ifndef COMPONENT_T1923634451_H
#define COMPONENT_T1923634451_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Component
struct  Component_t1923634451  : public Object_t631007953
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // COMPONENT_T1923634451_H
#ifndef BEHAVIOUR_T1437897464_H
#define BEHAVIOUR_T1437897464_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Behaviour
struct  Behaviour_t1437897464  : public Component_t1923634451
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // BEHAVIOUR_T1437897464_H
#ifndef MONOBEHAVIOUR_T3962482529_H
#define MONOBEHAVIOUR_T3962482529_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.MonoBehaviour
struct  MonoBehaviour_t3962482529  : public Behaviour_t1437897464
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MONOBEHAVIOUR_T3962482529_H
#ifndef POOLEDOBJECT_T2027872890_H
#define POOLEDOBJECT_T2027872890_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// PooledObject
struct  PooledObject_t2027872890  : public MonoBehaviour_t3962482529
{
public:
	// SimpleObjectPool PooledObject::pool
	SimpleObjectPool_t1028341060 * ___pool_4;

public:
	inline static int32_t get_offset_of_pool_4() { return static_cast<int32_t>(offsetof(PooledObject_t2027872890, ___pool_4)); }
	inline SimpleObjectPool_t1028341060 * get_pool_4() const { return ___pool_4; }
	inline SimpleObjectPool_t1028341060 ** get_address_of_pool_4() { return &___pool_4; }
	inline void set_pool_4(SimpleObjectPool_t1028341060 * value)
	{
		___pool_4 = value;
		Il2CppCodeGenWriteBarrier((&___pool_4), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // POOLEDOBJECT_T2027872890_H
#ifndef SHOPSCROLLLIST_T2357077533_H
#define SHOPSCROLLLIST_T2357077533_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// ShopScrollList
struct  ShopScrollList_t2357077533  : public MonoBehaviour_t3962482529
{
public:
	// UnityEngine.GameObject ShopScrollList::objectB
	GameObject_t1113636619 * ___objectB_4;
	// System.Collections.Generic.List`1<Building> ShopScrollList::buildings
	List_1_t2883330737 * ___buildings_5;
	// UnityEngine.Transform ShopScrollList::contentPanel
	Transform_t3600365921 * ___contentPanel_6;
	// UnityEngine.UI.Text ShopScrollList::moneyDisplay
	Text_t1901882714 * ___moneyDisplay_7;
	// SimpleObjectPool ShopScrollList::buttonObjectPool
	SimpleObjectPool_t1028341060 * ___buttonObjectPool_8;
	// System.Int32 ShopScrollList::counter
	int32_t ___counter_9;

public:
	inline static int32_t get_offset_of_objectB_4() { return static_cast<int32_t>(offsetof(ShopScrollList_t2357077533, ___objectB_4)); }
	inline GameObject_t1113636619 * get_objectB_4() const { return ___objectB_4; }
	inline GameObject_t1113636619 ** get_address_of_objectB_4() { return &___objectB_4; }
	inline void set_objectB_4(GameObject_t1113636619 * value)
	{
		___objectB_4 = value;
		Il2CppCodeGenWriteBarrier((&___objectB_4), value);
	}

	inline static int32_t get_offset_of_buildings_5() { return static_cast<int32_t>(offsetof(ShopScrollList_t2357077533, ___buildings_5)); }
	inline List_1_t2883330737 * get_buildings_5() const { return ___buildings_5; }
	inline List_1_t2883330737 ** get_address_of_buildings_5() { return &___buildings_5; }
	inline void set_buildings_5(List_1_t2883330737 * value)
	{
		___buildings_5 = value;
		Il2CppCodeGenWriteBarrier((&___buildings_5), value);
	}

	inline static int32_t get_offset_of_contentPanel_6() { return static_cast<int32_t>(offsetof(ShopScrollList_t2357077533, ___contentPanel_6)); }
	inline Transform_t3600365921 * get_contentPanel_6() const { return ___contentPanel_6; }
	inline Transform_t3600365921 ** get_address_of_contentPanel_6() { return &___contentPanel_6; }
	inline void set_contentPanel_6(Transform_t3600365921 * value)
	{
		___contentPanel_6 = value;
		Il2CppCodeGenWriteBarrier((&___contentPanel_6), value);
	}

	inline static int32_t get_offset_of_moneyDisplay_7() { return static_cast<int32_t>(offsetof(ShopScrollList_t2357077533, ___moneyDisplay_7)); }
	inline Text_t1901882714 * get_moneyDisplay_7() const { return ___moneyDisplay_7; }
	inline Text_t1901882714 ** get_address_of_moneyDisplay_7() { return &___moneyDisplay_7; }
	inline void set_moneyDisplay_7(Text_t1901882714 * value)
	{
		___moneyDisplay_7 = value;
		Il2CppCodeGenWriteBarrier((&___moneyDisplay_7), value);
	}

	inline static int32_t get_offset_of_buttonObjectPool_8() { return static_cast<int32_t>(offsetof(ShopScrollList_t2357077533, ___buttonObjectPool_8)); }
	inline SimpleObjectPool_t1028341060 * get_buttonObjectPool_8() const { return ___buttonObjectPool_8; }
	inline SimpleObjectPool_t1028341060 ** get_address_of_buttonObjectPool_8() { return &___buttonObjectPool_8; }
	inline void set_buttonObjectPool_8(SimpleObjectPool_t1028341060 * value)
	{
		___buttonObjectPool_8 = value;
		Il2CppCodeGenWriteBarrier((&___buttonObjectPool_8), value);
	}

	inline static int32_t get_offset_of_counter_9() { return static_cast<int32_t>(offsetof(ShopScrollList_t2357077533, ___counter_9)); }
	inline int32_t get_counter_9() const { return ___counter_9; }
	inline int32_t* get_address_of_counter_9() { return &___counter_9; }
	inline void set_counter_9(int32_t value)
	{
		___counter_9 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SHOPSCROLLLIST_T2357077533_H
#ifndef SIMPLEOBJECTPOOL_T1028341060_H
#define SIMPLEOBJECTPOOL_T1028341060_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// SimpleObjectPool
struct  SimpleObjectPool_t1028341060  : public MonoBehaviour_t3962482529
{
public:
	// UnityEngine.GameObject SimpleObjectPool::prefab
	GameObject_t1113636619 * ___prefab_4;
	// System.Collections.Generic.Stack`1<UnityEngine.GameObject> SimpleObjectPool::inactiveInstances
	Stack_1_t1957026074 * ___inactiveInstances_5;

public:
	inline static int32_t get_offset_of_prefab_4() { return static_cast<int32_t>(offsetof(SimpleObjectPool_t1028341060, ___prefab_4)); }
	inline GameObject_t1113636619 * get_prefab_4() const { return ___prefab_4; }
	inline GameObject_t1113636619 ** get_address_of_prefab_4() { return &___prefab_4; }
	inline void set_prefab_4(GameObject_t1113636619 * value)
	{
		___prefab_4 = value;
		Il2CppCodeGenWriteBarrier((&___prefab_4), value);
	}

	inline static int32_t get_offset_of_inactiveInstances_5() { return static_cast<int32_t>(offsetof(SimpleObjectPool_t1028341060, ___inactiveInstances_5)); }
	inline Stack_1_t1957026074 * get_inactiveInstances_5() const { return ___inactiveInstances_5; }
	inline Stack_1_t1957026074 ** get_address_of_inactiveInstances_5() { return &___inactiveInstances_5; }
	inline void set_inactiveInstances_5(Stack_1_t1957026074 * value)
	{
		___inactiveInstances_5 = value;
		Il2CppCodeGenWriteBarrier((&___inactiveInstances_5), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SIMPLEOBJECTPOOL_T1028341060_H





#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2300 = { sizeof (Building_t1411255995), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable2300[13] = 
{
	Building_t1411255995::get_offset_of_name_0(),
	Building_t1411255995::get_offset_of_price_1(),
	Building_t1411255995::get_offset_of_icon_2(),
	Building_t1411255995::get_offset_of_earnings_3(),
	Building_t1411255995::get_offset_of_isBuild_4(),
	Building_t1411255995::get_offset_of_isDestroyed_5(),
	Building_t1411255995::get_offset_of_kindOfBuilding_6(),
	Building_t1411255995::get_offset_of_armyForce_7(),
	Building_t1411255995::get_offset_of_armyForcePerStep_8(),
	Building_t1411255995::get_offset_of_ecologyCont_9(),
	Building_t1411255995::get_offset_of_peopleCont_10(),
	Building_t1411255995::get_offset_of_armyCont_11(),
	Building_t1411255995::get_offset_of_scienceCont_12(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2301 = { sizeof (ShopScrollList_t2357077533), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable2301[6] = 
{
	ShopScrollList_t2357077533::get_offset_of_objectB_4(),
	ShopScrollList_t2357077533::get_offset_of_buildings_5(),
	ShopScrollList_t2357077533::get_offset_of_contentPanel_6(),
	ShopScrollList_t2357077533::get_offset_of_moneyDisplay_7(),
	ShopScrollList_t2357077533::get_offset_of_buttonObjectPool_8(),
	ShopScrollList_t2357077533::get_offset_of_counter_9(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2302 = { sizeof (SimpleObjectPool_t1028341060), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable2302[2] = 
{
	SimpleObjectPool_t1028341060::get_offset_of_prefab_4(),
	SimpleObjectPool_t1028341060::get_offset_of_inactiveInstances_5(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize2303 = { sizeof (PooledObject_t2027872890), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable2303[1] = 
{
	PooledObject_t2027872890::get_offset_of_pool_4(),
};
#ifdef __clang__
#pragma clang diagnostic pop
#endif
