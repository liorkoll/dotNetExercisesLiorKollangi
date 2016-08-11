using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Jobs {
	static class NativeJob {
		[DllImport("kernel32")]
		public static extern IntPtr CreateJobObject(IntPtr sa, string name);

		[DllImport("kernel32", SetLastError = true)]
		public static extern bool AssignProcessToJobObject(IntPtr hjob, IntPtr hprocess);

		[DllImport("kernel32")]
		public static extern bool CloseHandle(IntPtr h);

		[DllImport("kernel32")]
		public static extern bool TerminateJobObject(IntPtr hjob, uint code);
}

	public class Job:IDisposable {
		private IntPtr _hJob;
		private List<Process> _processes;

		public Job(string name) {
           _hJob= NativeJob.CreateJobObject(IntPtr.Zero, name);
            if (_hJob == IntPtr.Zero) throw new InvalidOperationException("can't create job");
            _processes = new List<Process>();
            GC.AddMemoryPressure(1024);
            Console.WriteLine("The Job is created");
		}

		public Job()
			: this(null) {
		}

		protected void AddProcessToJob(IntPtr hProcess) {
			CheckIfDisposed();

			if(!NativeJob.AssignProcessToJobObject(_hJob, hProcess))
				throw new InvalidOperationException("Failed to add process to job");
		}

	    private void CheckIfDisposed()
	    {
            if (_hJob == IntPtr.Zero)
                throw new ObjectDisposedException("_hJob");
        }

	    public void AddProcessToJob(int pid) {
			AddProcessToJob(Process.GetProcessById(pid));
		}

		public void AddProcessToJob(Process proc) {
			Debug.Assert(proc != null);
			AddProcessToJob(proc.Handle);
			_processes.Add(proc);
		}

		public void Kill() {
            CheckIfDisposed();
            bool b = NativeJob.TerminateJobObject(_hJob, 0);
		}

        public void Dispose()
        {
            if (_hJob == IntPtr.Zero) return;
            Dispose(true);
        }

        private void Dispose(bool disposing)
        {
            NativeJob.CloseHandle(_hJob);
            if (disposing)
            {
                foreach(Process p in _processes)
                {
                    p.Dispose();
                    GC.SuppressFinalize(this);
                    _hJob = IntPtr.Zero;
                    
                }
                GC.RemoveMemoryPressure(1024);
                Console.WriteLine("the job was relased");
            }
        }
        ~Job()
        {
            
            Dispose(false);
        }
    }
}
