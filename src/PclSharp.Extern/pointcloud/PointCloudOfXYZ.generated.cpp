
// Code generated by a template
#pragma once
#include "..\export.h"

#include "pcl\pcl_base.h"
#include "pcl\point_types.h"

using namespace pcl;
using namespace std;

typedef vector<PointXYZ, Eigen::aligned_allocator<PointXYZ>> point_vector;

#ifdef __cplusplus  
extern "C" {  // only need to export C interface if  
			  // used by C++ source code  
#endif  

EXPORT(PointCloud<PointXYZ>*) pointcloud_xyz_ctor()
{
	return new PointCloud<PointXYZ>();
}

EXPORT(PointCloud<PointXYZ>*) pointcloud_xyz_ctor_wh(uint32_t width, uint32_t height)
{
	return new PointCloud<PointXYZ>(width, height);
}

EXPORT(PointCloud<PointXYZ>*) pointcloud_xyz_ctor_indices(PointCloud<PointXYZ>* cloud, vector<int>* indices)
{
	if (indices == NULL)
		return new PointCloud<PointXYZ>(*cloud);
	else
		return new PointCloud<PointXYZ>(*cloud, *indices);
}

EXPORT(void) pointcloud_xyz_delete(PointCloud<PointXYZ>** ptr)
{
	delete *ptr;
	*ptr = NULL;
}

EXPORT(PointXYZ*) pointcloud_xyz_at_colrow(PointCloud<PointXYZ>* ptr, int col, int row)
{
	return &ptr->at(col, row);
}

EXPORT(void) pointcloud_xyz_add(PointCloud<PointXYZ>* ptr, PointXYZ* value)
{
	//the value needs to be aligned to be pushed into the cloud, so do that.
	PointXYZ deref;
	memcpy(&deref, value, sizeof(PointXYZ));
	ptr->push_back(deref);
}

EXPORT(size_t) pointcloud_xyz_size(PointCloud<PointXYZ>* ptr)
{
	return ptr->size();
}

EXPORT(void) pointcloud_xyz_clear(PointCloud<PointXYZ>* ptr)
{
	ptr->clear();
}

EXPORT(uint32_t) pointcloud_xyz_width(PointCloud<PointXYZ>* ptr)
{
	return ptr->width;
}

EXPORT(void) pointcloud_xyz_width_set(PointCloud<PointXYZ>* ptr, uint32_t width)
{
	ptr->width = width;
}

EXPORT(uint32_t) pointcloud_xyz_height(PointCloud<PointXYZ>* ptr)
{
	return ptr->height;
}

EXPORT(void) pointcloud_xyz_height_set(PointCloud<PointXYZ>* ptr, uint32_t height)
{
	ptr->height = height;
}

EXPORT(int32_t) pointcloud_xyz_isOrganized(PointCloud<PointXYZ>* ptr)
{
	return ptr->isOrganized();
}

EXPORT(point_vector*) pointcloud_xyz_points(PointCloud<PointXYZ>* ptr)
{
	return &ptr->points;
}

EXPORT(PointXYZ*) pointcloud_xyz_data(PointCloud<PointXYZ>* ptr)
{
	return ptr->points.data();
}

EXPORT(void) pointcloud_xyz_downsample(PointCloud<PointXYZ>* ptr, int factor, PointCloud<PointXYZ>* output)
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

EXPORT(void) pointcloud_xyz_setIsDense(PointCloud<PointXYZ>* ptr, int value)
{ ptr->is_dense = value; }
EXPORT(int) pointcloud_xyz_getIsDense(PointCloud<PointXYZ>* ptr)
{ return ptr->is_dense; }

#ifdef __cplusplus  
}
#endif  
