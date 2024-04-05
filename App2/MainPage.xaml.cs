private void Button_Clicked(object sender, EventArgs e)
{
    List<string> userInfo = new List<string>();

    // Retrieve user input from entries
    string username = usernameEntry.Text;
    string password = passwordEntry.Text;
    string email = emailEntry.Text;
    string firstName = firstNameEntry.Text;
    string lastName = lastNameEntry.Text;
    string phoneNumber = phoneNumberEntry.Text;

    // Add user info to the list
    userInfo.Add(username);
    userInfo.Add(password);
    userInfo.Add(email);
    userInfo.Add(firstName);
    userInfo.Add(lastName);
    userInfo.Add(phoneNumber);

    // Display success message
    DisplayAlert("Success", "Signed up Successfully!", "OK");
}