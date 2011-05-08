using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using TheEntities;

namespace WcfQuestionAndAnswer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string GetData(int value);
        

        // TODO: Add your service operations here

        
        [OperationContract]
        Question NewQuestion();

        
        [OperationContract]
        int SaveQuestion(Question q);

        [OperationContract]
        Question OpenQuestion(int questionId);

        /*
        [OperationContract]
        Question OpenQuestion(int questionId);
         */

        [OperationContract]
        Question SaveQuestionReturnWhole(Question q);
    }


}
