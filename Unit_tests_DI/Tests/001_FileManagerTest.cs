﻿using Projects._001_Problem;
namespace Tests_001;

[TestFixture]
public class _001_FileManagerTest {

    [Test]
    public void FindLogFileTest1() {
        FileManager mgr = new FileManager();
        Assert.IsTrue(mgr.FindLogFile("file2.log"));
    }
}