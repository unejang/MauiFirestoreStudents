using MauiFireStudents.Services;
using MauiFireStudents.ViewModels;

namespace MauiFireStudents;

public partial class StudentPage : ContentPage
{
	public StudentPage()
	{
		InitializeComponent();
		var firestoreService = new FirestoreService();
		BindingContext = new StudentViewModel(firestoreService);
	}
}