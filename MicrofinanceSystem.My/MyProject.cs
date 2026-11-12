using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace MicrofinanceSystem.My;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class MyProject
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class MyForms
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public frmClients m_frmClients;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public frmCredits m_frmCredits;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public frmDashboard m_frmDashboard;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public frmFeedBack m_frmFeedBack;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public frmLoans m_frmLoans;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public frmlogin m_frmlogin;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public frmPayments m_frmPayments;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public frmRegistration m_frmRegistration;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public frmTransactionHistory m_frmTransactionHistory;

		public frmClients frmClients
		{
			get
			{
				m_frmClients = Create__Instance__(m_frmClients);
				return m_frmClients;
			}
			set
			{
				if (value != m_frmClients)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmClients);
				}
			}
		}

		public frmCredits frmCredits
		{
			get
			{
				m_frmCredits = Create__Instance__(m_frmCredits);
				return m_frmCredits;
			}
			set
			{
				if (value != m_frmCredits)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmCredits);
				}
			}
		}

		public frmDashboard frmDashboard
		{
			get
			{
				m_frmDashboard = Create__Instance__(m_frmDashboard);
				return m_frmDashboard;
			}
			set
			{
				if (value != m_frmDashboard)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmDashboard);
				}
			}
		}

		public frmFeedBack frmFeedBack
		{
			get
			{
				m_frmFeedBack = Create__Instance__(m_frmFeedBack);
				return m_frmFeedBack;
			}
			set
			{
				if (value != m_frmFeedBack)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmFeedBack);
				}
			}
		}

		public frmLoans frmLoans
		{
			get
			{
				m_frmLoans = Create__Instance__(m_frmLoans);
				return m_frmLoans;
			}
			set
			{
				if (value != m_frmLoans)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmLoans);
				}
			}
		}

		public frmlogin frmlogin
		{
			get
			{
				m_frmlogin = Create__Instance__(m_frmlogin);
				return m_frmlogin;
			}
			set
			{
				if (value != m_frmlogin)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmlogin);
				}
			}
		}

		public frmPayments frmPayments
		{
			get
			{
				m_frmPayments = Create__Instance__(m_frmPayments);
				return m_frmPayments;
			}
			set
			{
				if (value != m_frmPayments)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmPayments);
				}
			}
		}

		public frmRegistration frmRegistration
		{
			get
			{
				m_frmRegistration = Create__Instance__(m_frmRegistration);
				return m_frmRegistration;
			}
			set
			{
				if (value != m_frmRegistration)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmRegistration);
				}
			}
		}

		public frmTransactionHistory frmTransactionHistory
		{
			get
			{
				m_frmTransactionHistory = Create__Instance__(m_frmTransactionHistory);
				return m_frmTransactionHistory;
			}
			set
			{
				if (value != m_frmTransactionHistory)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmTransactionHistory);
				}
			}
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T Instance) where T : Form, new()
		{
			if (Instance == null || Instance.IsDisposed)
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(T)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(T), null);
				try
				{
					return new T();
				}
				catch (TargetInvocationException ex) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					ProjectData.SetProjectError(ex);
					return ex.InnerException != null;
				}).Invoke())
				{
					throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message), ex.InnerException);
				}
				finally
				{
					m_FormBeingCreated.Remove(typeof(T));
				}
			}
			return Instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance) where T : Form
		{
			instance.Dispose();
			instance = null;
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyForms()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal new Type GetType()
		{
			return typeof(MyForms);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class MyWebServices
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal new Type GetType()
		{
			return typeof(MyWebServices);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance)
		{
			instance = default;
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyWebServices()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class ThreadSafeObjectProvider<T> where T : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static T m_ThreadStaticValue;

		internal T GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new T();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ThreadSafeObjectProvider()
		{
		}
	}

	private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

	private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();

	private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider = new ThreadSafeObjectProvider<User>();

	private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();

	private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

	[HelpKeyword("My.Computer")]
	internal static MyComputer Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static MyApplication Application
	{
		[DebuggerHidden]
		get
		{
			return m_AppObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return m_UserObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static MyForms Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static MyWebServices WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
