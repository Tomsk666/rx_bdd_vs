jsonPWrapper ({
  "Features": [
    {
      "RelativeFolder": "NewEntries.feature",
      "Feature": {
        "Name": "NewEntries",
        "Description": "In order to create entries\r\nAs a KeePass user\r\nI want to be able to add, delete and edit entries",
        "FeatureElements": [
          {
            "Name": "Add User",
            "Slug": "add-user",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "That I am logged in to KeePass",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "i add an entry to the 'Windows' category",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "the entry should be listed in the main table",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          }
        ],
        "Result": {
          "WasExecuted": true,
          "WasSuccessful": true
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": true,
        "WasSuccessful": true
      }
    }
  ],
  "Summary": {
    "Tags": [],
    "Folders": [
      {
        "Folder": "NewEntries.feature",
        "Total": 1,
        "Passing": 1,
        "Failing": 0,
        "Inconclusive": 0
      }
    ],
    "NotTestedFolders": [
      {
        "Folder": "NewEntries.feature",
        "Total": 0,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 0
      }
    ],
    "Scenarios": {
      "Total": 1,
      "Passing": 1,
      "Failing": 0,
      "Inconclusive": 0
    },
    "Features": {
      "Total": 1,
      "Passing": 1,
      "Failing": 0,
      "Inconclusive": 0
    }
  },
  "Configuration": {
    "SutName": "BDD Ranorex Demo",
    "SutVersion": "1.0",
    "GeneratedOn": "24 August 2017 11:13:05"
  }
});