#!/usr/bin/env python
import rospy
from std_msgs.msg import String
from rospy.numpy_msg import numpy_msg
from rospy_tutorials.msg import Floats

import rospy
from rospy_tutorials.msg import Floats

def callback(data):
    test_img = data.data.reshape((1,120,160,3))
    print(rospy.get_name(), "I heard %s"%str(test_img))

def listener():
    rospy.init_node('listener')
    rospy.Subscriber("chatter", numpy_msg(Floats), callback)
    rospy.spin()

if __name__ == '__main__':
    listener()
