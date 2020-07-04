namespace MyFirstMLProject
{
    using System.Collections.Generic;
    using Models;

    public static class TasksInfo
    {
        public static IEnumerable<WorkTask> GetAvailableTasks()
        {
            return new List<WorkTask>()
            {
                new WorkTask
                {
                    Id = 1,
                    Name = "Unsecured CA",
                    Department = "CA",
                    Section = "Micro",
                    Minutes = 25
                },
                new WorkTask
                {
                    Id = 2,
                    Name = "Secured CA",
                    Department = "CA",
                    Section = "Micro",
                    Minutes = 45
                },
                new WorkTask
                {
                    Id = 3,
                    Name = "Нов Бизнес CMS CA",
                    Department = "CA",
                    Section = "Micro",
                    Minutes = 20
                },
                new WorkTask
                {
                    Id = 4,
                    Name = "Преструктуриране",
                    Department = "CA",
                    Section = "Micro",
                    Minutes = 45
                },
                new WorkTask
                {
                    Id = 5,
                    Name = "ОСВ",
                    Department = "CA",
                    Section = "Micro",
                    Minutes = 10
                },
                new WorkTask
                {
                    Id = 6,
                    Name = "Maintenance",
                    Department = "CA",
                    Section = "Micro",
                    Minutes = 15
                },
                new WorkTask
                {
                    Id = 7,
                    Name = "Промени по кредит",
                    Department = "CA",
                    Section = "Micro",
                    Minutes = 30
                },
                new WorkTask
                {
                    Id = 8,
                    Name = "Closure (Full Repayment)",
                    Department = "CA",
                    Section = "Micro",
                    Minutes = 10
                },
                new WorkTask
                {
                    Id = 9,
                    Name = "Maintenance CMS",
                    Department = "CA",
                    Section = "Micro",
                    Minutes = 20
                },
                new WorkTask
                {
                    Id = 10,
                    Name = "Жалби/кореспонденции казуси",
                    Department = "CA",
                    Section = "Micro",
                    Minutes = 380
                },
                new WorkTask
                {
                    Id = 11,
                    Name = "Застраховки",
                    Department = "CA",
                    Section = "Micro",
                    Minutes = 15
                },
                new WorkTask
                {
                    Id = 12,
                    Name = "Мониторинг",
                    Department = "CA",
                    Section = "Micro",
                    Minutes = 10
                },
                new WorkTask
                {
                    Id = 13,
                    Name = "Monitoring Ипотеки CMS",
                    Department = "CA",
                    Section = "Micro",
                    Minutes = 20
                },
                new WorkTask
                {
                    Id = 14,
                    Name = "Справки (без мониторингови)",
                    Department = "CA",
                    Section = "Micro",
                    Minutes = 10
                },
                new WorkTask
                {
                    Id = 15,
                    Name = "DQIs",
                    Department = "CA",
                    Section = "Micro",
                    Minutes = 5
                },
                new WorkTask
                {
                    Id = 16,
                    Name = "KPIs 15",
                    Department = "CA",
                    Section = "Micro",
                    Minutes = 15
                },
                new WorkTask
                {
                    Id = 17,
                    Name = "TTCompl CL (min)",
                    Department = "CA",
                    Section = "PI",
                    Minutes = 10
                },
                new WorkTask
                {
                    Id = 18,
                    Name = "TTCompl ML+HL New (min)",
                    Department = "CA",
                    Section = "PI",
                    Minutes = 45
                },
                new WorkTask
                {
                    Id = 19,
                    Name = "Завеждане на фасилити (min)",
                    Department = "CA",
                    Section = "PI",
                    Minutes = 30
                },
                new WorkTask
                {
                    Id = 20,
                    Name = "Input/Verify loan number and facility in IBM BPM (min)",
                    Department = "CA",
                    Section = "PI",
                    Minutes = 3
                },
                new WorkTask
                {
                    Id = 21,
                    Name = "Нов Бизнес CMS (min)",
                    Department = "CA",
                    Section = "PI",
                    Minutes = 5
                },
                new WorkTask
                {
                    Id = 22,
                    Name = "Disb. Input",
                    Department = "CA",
                    Section = "PI",
                    Minutes = 3
                },
                new WorkTask
                {
                    Id = 23,
                    Name = "Робот процеси DISB",
                    Department = "CA",
                    Section = "PI",
                    Minutes = 2
                },
                new WorkTask
                {
                    Id = 24,
                    Name = "Преструктурирания (min)",
                    Department = "CA",
                    Section = "PI",
                    Minutes = 40
                },
                new WorkTask
                {
                    Id = 25,
                    Name = "Архив на кредити (min)",
                    Department = "CA",
                    Section = "PI",
                    Minutes = 3
                },
                new WorkTask
                {
                    Id = 26,
                    Name = "ОСВ (min)",
                    Department = "CA",
                    Section = "PI",
                    Minutes = 10
                },
                new WorkTask
                {
                    Id = 27,
                    Name = "Отпаднали Робот процеси ОСВ",
                    Department = "CA",
                    Section = "PI",
                    Minutes = 5
                },
                new WorkTask
                {
                    Id = 28,
                    Name = "Maintenance",
                    Department = "CA",
                    Section = "PI",
                    Minutes = 10
                },
                new WorkTask
                {
                    Id = 29,
                    Name = "Промени по кредит",
                    Department = "CA",
                    Section = "PI",
                    Minutes = 7
                },
                new WorkTask
                {
                    Id = 30,
                    Name = "Жалби",
                    Department = "CA",
                    Section = "PI",
                    Minutes = 345
                },
                new WorkTask
                {
                    Id = 31,
                    Name = "Въвеждане/Потвърждение на ръчни сч. форми",
                    Department = "CA",
                    Section = "PI",
                    Minutes = 1
                },
                new WorkTask
                {
                    Id = 32,
                    Name = "Мониторинг",
                    Department = "CA",
                    Section = "PI",
                    Minutes = 10
                },
                new WorkTask
                {
                    Id = 33,
                    Name = "Застраховки",
                    Department = "CA",
                    Section = "PI",
                    Minutes = 15
                },
                new WorkTask
                {
                    Id = 34,
                    Name = "Maintenance CMS",
                    Department = "CA",
                    Section = "PI",
                    Minutes = 15
                },
                new WorkTask
                {
                    Id = 35,
                    Name = "Monitoring CMS",
                    Department = "CA",
                    Section = "PI",
                    Minutes = 15
                },
                new WorkTask
                {
                    Id = 36,
                    Name = "Справки (без мониторингови)",
                    Department = "CA",
                    Section = "PI",
                    Minutes = 10
                },
                new WorkTask
                {
                    Id = 37,
                    Name = "DQIs",
                    Department = "CA",
                    Section = "PI",
                    Minutes = 5
                },
                new WorkTask
                {
                    Id = 38,
                    Name = "KPIs",
                    Department = "CA",
                    Section = "PI",
                    Minutes = 60
                },
                new WorkTask
                {
                    Id = 3,
                    Name = "Робот Въвеждане/Потвърждение на ръчни сч. форми",
                    Department = "CA",
                    Section = "PI",
                    Minutes = 1
                },
            };
        }
    }
}