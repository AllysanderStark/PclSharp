#pragma once
#include "..\export.h"
#include <pcl/io/pcd_io.h>

using namespace pcl;
using namespace std;

#ifdef __cplusplus
extern "C" {
#endif

	EXPORT(void) io_concatenateFields(const PointCloud<PointXYZ>* &cloud1_in, const PointCloud<Normal>* &cloud2_in, PointCloud<PointNormal> &cloud_out)
	{
		concatenateFields(*cloud1_in, *cloud2_in, cloud_out);
	}


#ifdef __cplusplus  
}
#endif
