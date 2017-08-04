using Budget.window;
using Presentation;

namespace Budget
{

    public partial class ConfirmDeleteWindow : AbstractWindow
    {
        #region Constructors

        public ConfirmDeleteWindow(AbstractModel model)
        {
            Initialize(model);
        }

        #endregion

        #region Properties

        private AbstractModel Model { get; set; }
        private ConfirmDeletePresenter Presenter { get; set; }

        #endregion

        private void buttonYes_Click(object sender, System.EventArgs e)
        {

            Presenter.Delete(Model as AccountModel);
            Presenter.Delete(Model as PayDayModel);
            Close();
        }

        private void buttonNo_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void Initialize(AbstractModel model)
        {
            InitializeComponent();
            Presenter = new ConfirmDeletePresenter();
            Model = model;

        }
    }

}
