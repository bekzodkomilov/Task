namespace tasks.Mapper
{
    public static class ModelEntityMapper
    {
        public static Entity.Tasking ToTaskEntity(this Model.NewTask newTask)
        {
            return new Entity.Tasking(
                title: newTask.Title,
                description: newTask.Description,
                tags: newTask.Tags is null ? string.Empty : string.Join(',', newTask.Tags),
                location: newTask.Location is null ? string.Empty : string.Format($"{newTask.Location.Latitude},{newTask.Location.Longitude}"),
                atATime: newTask.AtATime,
                onADay: newTask.OnADay,
                repeat: newTask.Repeat.ToEntityETaskRepeat(),
                status: newTask.Status.ToEntityETaskStatus(),
                priorety: newTask.Priorety.ToEntityETaskPriorety(),
                url: newTask.Url
            );
        }

          public static Entity.Tasking ToTaskEntity(this Model.UpdatedTask task)
        {
            return new Entity.Tasking(
                title: task.Title,
                description: task.Description,
                tags: task.Tags is null ? string.Empty : string.Join(',', task.Tags),
                location: task.Location is null ? string.Empty : string.Format($"{task.Location.Latitude},{task.Location.Longitude}"),
                atATime: task.AtATime,
                onADay: task.OnADay,
                repeat: task.Repeat.ToEntityETaskRepeat(),
                status: task.Status.ToEntityETaskStatus(),
                priorety: task.Priorety.ToEntityETaskPriorety(),
                url: task.Url)
                {
                    Id = task.Id
                };
        }

         public static Entity.Tasking ToTaskEntity(this Model.NewTAskModel task)
        {
            return new Entity.Tasking(
                title: task.Title,
                description: task.Description,
                tags: task.Tags is null ? string.Empty : string.Join(',', task.Tags),
                location: task.Location is null ? string.Empty : string.Format($"{task.Location.Latitude},{task.Location.Longitude}"),
                atATime: task.AtATime,
                onADay: task.OnADay,
                repeat: task.Repeat.ToEntityETaskRepeat(),
                status: task.Status.ToEntityETaskStatus(),
                priorety: task.Priorety.ToEntityETaskPriorety(),
                url: task.Url)
                {
                    Id = task.Id
                };
        }
    }
}