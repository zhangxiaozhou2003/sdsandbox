# #!/usr/bin/env python
# import rospy
# from std_msgs.msg import String
# from geometry_msgs.msg import Pose
#
# def talker():
#     ik_pose = Pose()
#     ik_pose.position.x = 5
#     ik_pose.position.y = 4
#     ik_pose.position.z = 3
#     ik_pose.orientation.x = 0
#     ik_pose.orientation.y = 0
#     ik_pose.orientation.z = 0
#     ik_pose.orientation.w = 1
#     pub = rospy.Publisher('chatter', Pose, queue_size=10)
#     rospy.init_node('talker', anonymous=True)
#     rate = rospy.Rate(10) # 10hz
#     while not rospy.is_shutdown():
#
#         rospy.loginfo(ik_pose)
#         pub.publish(ik_pose)
#         rate.sleep()
#
# if __name__ == '__main__':
#     try:
#         talker()
#     except rospy.ROSInterruptException:
#         pass

#!/usr/bin/env python
# license removed for brevity
import rospy
from std_msgs.msg import String

def talker():
    pub = rospy.Publisher('chatter', String, queue_size=10)
    rospy.init_node('talker', anonymous=True)
    rate = rospy.Rate(10) # 10hz
    while not rospy.is_shutdown():
        hello_str = "hello world %s" % rospy.get_time()
        rospy.loginfo(hello_str)
        pub.publish(hello_str)
        rate.sleep()

if __name__ == '__main__':
    try:
        talker()
    except rospy.ROSInterruptException:
        pass
