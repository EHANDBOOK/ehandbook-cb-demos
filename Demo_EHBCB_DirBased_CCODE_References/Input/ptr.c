


void SetPtrValue(int * ptr, int value)
{
	*ptr = value;
}

void IncrementContent(int *ptr)
{
	(*ptr)++;
}

void PreDecrementContent(int *ptr)
{
	--(*ptr) ;
}

void PostIncrementPtr(int *ptr)
{
	*ptr++ = 1;
}

void PreDecrementPtr(int *ptr)
{
	*--ptr = 1;
}

void CopyContentWithOffset(int * src, int * dest, unsigned int offset)
{
	*(dest + offset) = *(offset + src);
}

void CopyContentWithIndex(int * src, int * dest, unsigned int offset)
{
	dest[offset] = *(offset + src);
}

int DereferencingPtrPtr(int ** ptr)
{
	return **ptr;
}

int PtrToFunktion(int (*fkt)())
{
	return fkt();
}
