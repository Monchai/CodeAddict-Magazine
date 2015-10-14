Todo = new Mongo.Collection("todo");
//------------------------------------------------------
if (Meteor.isClient) {
  
    Template.todoList.helpers({
        getTodoList : function(){
            return Todo.find({});            
        }        
    });
    //---------------------------------------------
    Template.todoCommand.events({
        "submit form" : function(event){
            event.preventDefault();            
            var jobName = event.target.txtJobName.value;
            var jobBy = event.target.txtJobBy.value;            

            Todo.insert({
                job_name : jobName,
                job_by : jobBy
            });      

        }    
    });
}
//------------------------------------------------------
if (Meteor.isServer) {
    Meteor.startup(function () {
        Todo.remove({});
    });
}
//------------------------------------------------------