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
        private int _size;
        private bool _disposed = false;

		public Job(string name) {
            
           _hJob= NativeJob.CreateJobObject(IntPtr.Zero, name);
            if (_hJob == IntPtr.Zero) throw new InvalidOperationException("can't create job");
            _processes = new List<Process>();
         
		}

		public Job()
			: this(null) {
		}
        public Job(int size){
            _size = size;
               GC.AddMemoryPressure(_size);
            Console.WriteLine("The Job is created");

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
            if (_disposed) return;
            if (disposing)
            {
                foreach(Process p in _processes)
                {
                    p.Dispose();        
                 
                }
                _processes = null;
             
            }
            NativeJob.CloseHandle(_hJob);
            if (_size > 0)
            {
                GC.RemoveMemoryPressure(_size);
               
                _disposed = true;
            }
        


        }
        ~Job()
        {
            Console.WriteLine("the job is disposing");
            Dispose(false);
           // GC.RemoveMemoryPressure(_size);
            //Console.WriteLine("the job was relased");
            //_disposed = true;
            
        }
    }
}
