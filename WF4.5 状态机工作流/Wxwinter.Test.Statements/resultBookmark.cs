using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wxwinter.Test.Statements
{
    public sealed class resultBookmark : NativeActivity<string>
    {

        public InArgument<string> bookmarkName { get; set; }



        protected override bool CanInduceIdle
        {

            get

            { return true; }

        }

        protected override void Execute(NativeActivityContext context)
        {

            string bookmark = context.GetValue(bookmarkName);

            context.CreateBookmark(bookmark, new BookmarkCallback(bookmarkCallback));

            System.Console.WriteLine("创建bookmark:{0}", bookmark);

        }

        void bookmarkCallback(NativeActivityContext context, Bookmark bookmark, object obj)
        {
            if (obj != null)
            {
                this.Result.Set(context, obj.ToString());
            }
            else
            {

                this.Result.Set(context, string.Empty);
            }

        }

    }

}
