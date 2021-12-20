// using System;
// using System.Linq;
// using tasks.Model;

// namespace tasks.Mapper
// {
//       public static class EntityModelMapper
//   {
//       public static Model.NewTask ToTaskModel(this Entity.Tasking task)
//         {
//             return new Model.NewTask()
//             {
//                 Title = task.Title,
//                 Description = task.Description,
//                 Tags = task.Tags.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList(),
//                 Location = new TaskLocation(){Latitude=Convert.ToDouble(task.Location.Split(',')[0]), Longitude=Convert.ToDouble(task.Location.Split(',')[1])},
//                 AtATime = task.AtATime,
//                 OnADay = task.OnADay,
//                 Repeat = task.Repeat.ToModelETaskRepeat(),
//                 Status = task.Status.ToModelETaskStatus(),
//                 Priorety = task.Priorety.ToModelETaskPriorety(),
//                 Url = task.Url,
//             };
//         }
//    }
// }