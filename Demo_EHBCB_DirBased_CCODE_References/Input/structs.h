
// a simple struct type name
struct StructTypeName {
	int value;
};

// a forward declaration
struct StructTypeForwardDecl;

// a new type name for struct
typedef struct StructTypeName StructNameTypedef;

// the definition of forward declaration struct
struct StructTypeForwardDecl {
	int value;
};

// a nested struct
struct NestedStruct {
	struct StructTypeForwardDecl inner;
	// typedefed inner struct
	StructNameTypedef innerTypedef;
};


void UnnamedStructAccess(int value);
void SimpleNamedMemberAssignment(int value);
void SimpleNamedInstanceAssignment();
void NestedAssignment(int value);
void SameNamedTypeAndVariable(int value);
void CyclicReferences(int value);
void LinkedElements(int value);
void SelfRef(int value);