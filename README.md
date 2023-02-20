# ProjectFeedbackApi
Simple API where you can save Projects and Feedback for those project. Doesn't currently connect specific feedback to specific project. 

You need to add your own connectionString to appsetting.json.

You can download it here: https://www.microsoft.com/en-us/sql-server/sql-server-downloads

Add Project Table with ProjectId and name column
Feedback Table with FeedbackId, FeedbackTitle and FeedbackMessage columns
and ProjectFeedback table RowId ProjectId and FeedbackId columns to database. 
