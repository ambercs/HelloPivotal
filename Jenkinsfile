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
        powershell 'C:\\Users\\administrator\\Desktop\\script.bat'
      }
    }
  }
}