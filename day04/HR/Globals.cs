using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day04
{
    public static class Globals
    {
        public static int GlobalUserId { get; private set; }
        public static void SetGlobalUserId(int userId)
        {
            GlobalUserId = userId;
        }
        //Student ID
        public static int GlobalStudentId { get; private set; }
        public static void SetGlobalStudentId(int stdId)
        {
            GlobalStudentId = stdId;
        }
        //Course ID
        public static int GlobalCourseId { get; private set; }
        public static void SetGlobalCourseId(int cId)
        {
            GlobalCourseId = cId;
        }
        //Group ID
        public static int GlobalGroupId { get; private set; }
        public static void SetGlobalGroupId(int gId)
        {
            GlobalGroupId = gId;
        }
        //ContactID
        public static int GlobalContactId { get; private set; }
        public static void SetGlobalContactId(int cId)
        {
            GlobalContactId = cId;
        }
    }
}
