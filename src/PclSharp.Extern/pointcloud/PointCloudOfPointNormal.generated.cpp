
// Code generated by a template
#pragma once
#include "..\export.h"

#include "pcl\pcl_base.h"
#include "pcl\point_types.h"

using namespace pcl;
using namespace std;

typedef vector<PointNormal, Eigen::aligned_allocator<PointNormal>> point_vector;

#ifdef __cplusplus  
extern "C" {  // only need to export C interface if  
			  // used by C++ source code  
#endif  

EXPORT(PointCloud<PointNormal>*) pointcloud_pointnormal_ctor()
{
	return new PointCloud<PointNormal>();
}

EXPORT(PointCloud<PointNormal>*) pointcloud_pointnormal_ctor_wh(uint32_t width, uint32_t height)
{
	return new PointCloud<PointNormal>(width, height);
}

EXPORT(PointCloud<PointNormal>*) pointcloud_pointnormal_ctor_indices(PointCloud<PointNormal>* cloud, vector<int>* indices)
{
	if (indices == NULL)
		return new PointCloud<PointNormal>(*cloud);
	else
		return new PointCloud<PointNormal>(*cloud, *indices);
}

EXPORT(void) pointcloud_pointnormal_delete(PointCloud<PointNormal>** ptr)
{
	delete *ptr;
	*ptr = NULL;
}

EXPORT(PointNormal*) pointcloud_pointnormal_at_colrow(PointCloud<PointNormal>* ptr, int col, int row)
{
	return &ptr->at(col, row);
}

EXPORT(void) pointcloud_pointnormal_add(PointCloud<PointNormal>* ptr, PointNormal* value)
{
	//the value needs to be aligned to be pushed into the cloud, so do that.
	PointNormal deref;
	memcpy(&deref, value, sizeof(PointNormal));
	ptr->push_back(deref);
}

EXPORT(size_t) pointcloud_pointnormal_size(PointCloud<PointNormal>* ptr)
{
	return ptr->size();
}

EXPORT(void) pointcloud_pointnormal_clear(PointCloud<PointNormal>* ptr)
{
	ptr->clear();
}

EXPORT(uint32_t) pointcloud_pointnormal_width(PointCloud<PointNormal>* ptr)
{
	return ptr->width;
}

EXPORT(void) pointcloud_pointnormal_width_set(PointCloud<PointNormal>* ptr, uint32_t width)
{
	ptr->width = width;
}

EXPORT(uint32_t) pointcloud_pointnormal_height(PointCloud<PointNormal>* ptr)
{
	return ptr->height;
}

EXPORT(void) pointcloud_pointnormal_height_set(PointCloud<PointNormal>* ptr, uint32_t height)
{
	ptr->height = height;
}

EXPORT(int32_t) pointcloud_pointnormal_isOrganized(PointCloud<PointNormal>* ptr)
{
	return ptr->isOrganized();
}

EXPORT(point_vector*) pointcloud_pointnormal_points(PointCloud<PointNormal>* ptr)
{
	return &ptr->points;
}

EXPORT(PointNormal*) pointcloud_pointnormal_data(PointCloud<PointNormal>* ptr)
{
	return ptr->points.data();
}

EXPORT(void) pointcloud_pointnormal_downsample(PointCloud<PointNormal>* ptr, int factor, PointCloud<PointNormal>* output)
{
	if (output->width != ptr->width/factor ||
		output->height != ptr->height/factor)
	{
		output->resize(ptr->width/factor * ptr->height/factor);
		output->width = ptr->width/factor;
		output->height = ptr->height/factor;
		output->is_dense = ptr->is_dense;
	}

	if (factor == 1)
	{
		output->points = ptr->points;
		return;
	}

	auto ow = output->width;
	auto oh = output->height;
	auto iw = ptr->width;

	auto oarr = output->points.data();
	auto iarr = ptr->points.data();

	for(size_t c = 0; c < ow; c++)
	{
		for(size_t r = 0; r < oh; r++)
		{
			oarr[r * ow + c] = iarr[r * factor * iw + c * factor];
		}
	}
}

EXPORT(void) pointcloud_pointnormal_setIsDense(PointCloud<PointNormal>* ptr, int value)
{ ptr->is_dense = value; }
EXPORT(int) pointcloud_pointnormal_getIsDense(PointCloud<PointNormal>* ptr)
{ return ptr->is_dense; }

#ifdef __cplusplus  
}
#endif  
