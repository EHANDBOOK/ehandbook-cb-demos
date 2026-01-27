
// some structs are defined here for global use
#include "structs.h"

// definition of NULL is found here
#include "stddef.h"


// a struct without a type name (once type)
struct {
	int value;
} NoName;

// a nested struct without a type name
struct {
	struct {
		struct nested {
			struct {
				int innermost;
			} inner3;
		} inner2;
	} inner1;
} NestedNoName;

// a simple global variable
struct StructTypeName simple;

// a simple global variable via new type
StructNameTypedef simpleViaTypeDef;

// declaration and instatiation in one step
struct DeclareAndAssign {
	int value;
} GlobalStruct;

// type name, variable name and member name are same but still distinguished by compiler
struct SameName {
	int SameName;
} SameName;



// self referencing type
struct Linked {
	int nr;
	struct Linked * next;
} Head, Tail;

// forward reference to allow for a cyclic reference
struct LeftWing;

struct RightWing {
	int value;
	struct LeftWing * left;
} rightWing;

struct LeftWing {
	int value;
	struct RightWing * right;
} leftWing;

struct SelfReferencing {
	struct SelfReferencing * parent;
} * selfRef;


void UnnamedStructAccess(int value)
{
	NoName.value = value;
}

void SimpleNamedMemberAssignment(int value)
{
	// memberwise assignment
	simple.value = value;
	simpleViaTypeDef.value = value;
}

void SimpleNamedInstanceAssignment()
{
	// instance assignment
	simple = simpleViaTypeDef;
}

void NestedAssignment(int value)
{
	struct NestedStruct nested;
	nested.inner.value = value;
	nested.innerTypedef.value = value;
}

void NestedInnerAssignment(int value)
{
	NestedNoName.inner1.inner2.inner3.innermost = value;
}

void SameNamedTypeAndVariable(int value)
{
	// use type name
	struct SameName sameName;
	sameName.SameName = value;
	// use variable name
	SameName.SameName = value;
}

void CyclicReferences(int value)
{
	// reference right from the left
	leftWing.value = value;
	leftWing.right = &rightWing;
	// reference left from the right
	rightWing.value = value;
	rightWing.left = &leftWing;
}

void LinkedElements(int value)
{
	// pointer to a struct
	Head.next = &Tail;
	Head.nr = value;
	Head.next->nr = value;
	Head.next->next = NULL;
}

void SelfRef(int value)
{
	struct SelfReferencing parent;
	// initialize
	selfRef = &parent;
	// and access
	selfRef->parent = NULL;
}

void StructMain(int value)
{
	UnnamedStructAccess(value);
	SimpleNamedMemberAssignment(value);
	NestedAssignment(value);
	NestedInnerAssignment(value);
	SameNamedTypeAndVariable(value);
	SameNamedTypeAndVariable(value);
	CyclicReferences(value);
	LinkedElements(value);
	SelfRef(value);
}
