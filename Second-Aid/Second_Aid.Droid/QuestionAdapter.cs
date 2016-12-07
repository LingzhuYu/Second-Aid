using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;
using Second_Aid.Droid.Models;

namespace Second_Aid.Droid
{
    public class QuestionAdapter: BaseAdapter
    {
        Activity _activity;
        List<Question> questionList;
        List<string> questions;

        public QuestionAdapter(Activity activity, List<string> q)
        {
            _activity = activity;
            this.questions = q;

        }



        public override int Count
        {
            get
            {
                return questions.Count;
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            throw new NotImplementedException();
        }

        public override long GetItemId(int position)
        {
            throw new NotImplementedException();
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            //throw new NotImplementedException();
            var view = convertView ?? _activity.LayoutInflater.Inflate(
                Resource.Layout.QuestionRow, parent, false);
            var questionTitle = view.FindViewById<TextView>(Resource.Id.Header);
            var questionAnswer = view.FindViewById<EditText>(Resource.Id.Input);
            questionTitle.Text = questions[position];

            return view;
        }
    }
}