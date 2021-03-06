
// Code generated by a template
#pragma once
#include "..\export.h"
#include <vector>
#include "pcl\point_types.h"


using namespace std;
using namespace pcl;


typedef vector<PointNormal> vectorType;

#ifdef __cplusplus  
extern "C" {  
#endif

EXPORT(vectorType*) std_vector_pointnormal_ctor()
{
	return new vector<PointNormal>();
}

EXPORT(vectorType*) std_vector_pointnormal_ctor_count(int count)
{
	return new vector<PointNormal>(count);
}

EXPORT(void) std_vector_pointnormal_delete(vector<PointNormal>** ptr)
{
	delete *ptr;
	*ptr = NULL;
}

EXPORT(void) std_vector_pointnormal_at(vector<PointNormal>* ptr, size_t idx, PointNormal* value)
{
	*value = ptr->at(idx);
}

EXPORT(size_t) std_vector_pointnormal_size(vector<PointNormal>* ptr)
{
	return ptr->size();
}

EXPORT(void) std_vector_pointnormal_clear(vector<PointNormal>* ptr)
{
	ptr->clear();
}

EXPORT(void) std_vector_pointnormal_resize(vector<PointNormal>* ptr, int32_t size)
{
	ptr->resize(size);
}

EXPORT(void) std_vector_pointnormal_add(vector<PointNormal>* ptr, PointNormal value)
{
	
//the value needs to be aligned to be pushed into the cloud, so do that.
	PointNormal deref;
	memcpy(&deref, &value, sizeof(PointNormal));
	ptr->push_back(deref);

}

EXPORT(void) std_vector_pointnormal_insert(vector<PointNormal>* ptr, ptrdiff_t index, PointNormal value)
{
	
//the value needs to be aligned to be pushed into the cloud, so do that.
	PointNormal deref;
	memcpy(&deref, &value, sizeof(PointNormal));
	ptr->insert(ptr->begin()+index, deref);

}

EXPORT(PointNormal*) std_vector_pointnormal_data(vector<PointNormal>* ptr)
{
	return ptr->data();
}

#ifdef __cplusplus  
}
#endif
