// puts the LetterVariables class in the FriendLetter.Models namespace so that we have access to it whenever using FriendLetter.Models; is declared.

namespace FriendLetter.Models
{
  public class LetterVariable
  {
    private string _recipient;
    private string _sender;

    public string GetRecipient()
    {
      return _recipient;
    }

    public void SetRecipient(string newRecipient)
    {
      _recipient = newRecipient;
    }
    public string GetSender()
    {
      return _sender;
    }

    public void SetSender(string newSender)
    {
      _sender = newSender;
    }
  }
}
