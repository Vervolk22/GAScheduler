using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace GA
{
    protected internal class RandomScheduleGenerator
    {
        Random rnd;
        List<Group> groups;
        List<Curriculum> curriculum;
        List<Audience> audiences;
        List<Subject> subjects;

        LinkedList<Group> currGroups;
        LinkedList<Subject> currSubjects;

        protected internal RandomScheduleGenerator(List<Group> groups, List<Curriculum> curriculum,
                List<Audience> audiences, List<Subject> subjects)
        {
            this.groups = groups;
            this.curriculum = curriculum;
            this.audiences = audiences;
            this.subjects = subjects;
            rnd = new Random();
        }

        protected internal Schedule getRandomSchedule(int scheduleId)
        {
            resetVariables();
            Group group;
            while ((group = getRandomIncompleteGroup()) != null)
            {
                SubjectCurriculum sc = getRandomIncompleteClass(group);
                ClassType ct = getRandomClassType(sc);
                Professor professor = getBestProfessor(sc, ct);
                Classes classes = getNewClasses(group, sc, ct, professor);
            }
        }

        protected internal void resetVariables() {
            currGroups = new LinkedList<Group>();
            foreach (Group g in groups)
            {
                currGroups.AddLast(Group.copy(g));
            }
            currSubjects = new LinkedList<Subject>();
            foreach (Subject subject in subjects)
            {
                currSubjects.AddLast(Subject.copy(subject));
            }
            
        }

        protected internal Group getRandomIncompleteGroup()
        {
            while (true)
            {
                int num = rnd.Next(currGroups.Count);
                if (!currGroups.ElementAt(num).isIncomplete())
                {
                    currGroups.Remove(currGroups.ElementAt(num));
                }
                else
                {
                    return currGroups.ElementAt(num);
                }
                if (currGroups.Count == 0) return null;
            }
        }

        protected internal SubjectCurriculum getRandomIncompleteClass(Group group) {
            while (true)
            {
                int num = rnd.Next(group.plan.curriculum.Count);
                if (!group.plan.curriculum.ElementAt(num).isIncomplete())
                {
                    group.plan.curriculum.Remove(group.plan.curriculum.ElementAt(num));
                }
                else
                {
                    return group.plan.curriculum.ElementAt(num);
                }
            }
            //SubjectCurriculum sc = group.plan.curriculum
        }

        protected internal ClassType getRandomClassType(SubjectCurriculum sc)
        {
            int count = 0;
            if (sc.lectureCount > 0) count++;
            if (sc.labsCount > 0) count++;
            if (sc.practiceCount > 0) count++;
            int num = rnd.Next(count);

            if (count == 0) return ClassType.lecture;
            if (sc.lectureCount > 0) count--;
            if (count == 0) return ClassType.lab;
            return ClassType.practice;
        }

        protected internal Professor getBestProfessor(SubjectCurriculum sc, ClassType ct)
        {
            int max = 200;
            Professor result = null;
            bool lectureRequired = ct == ClassType.Lecture ? true : false;
            foreach (TeachPossibility tp in sc.subject.canTeached)
            {
                if (tp.professor.busyness < max)
                {
                    max = tp.professor.busyness;
                    result = tp.professor;
                }
            }
            return result;
        }

        protected internal Classes getNewClasses(Group group, SubjectCurriculum sc,
                ClassType ct, Professor professor)
        {
            return null;
        }
    }
}
