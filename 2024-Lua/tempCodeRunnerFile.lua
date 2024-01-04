function People:speak()
    self.name = self.name .. "|"
    print(self, self.name)
end