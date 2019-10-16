pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        powershell 'get-service'
      }
    }
    stage('Batch') {
      steps {
        powershell 'cmd.exe /c \'C:\\Users\\administrator\\Desktop\\script.bat\''
      }
    }
  }
}